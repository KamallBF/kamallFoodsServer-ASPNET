﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Misc;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Security;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SecurityToken = Kamall_foods_server_aspNetCore.Data.Models.Misc.SecurityToken;

namespace Kamall_foods_server_aspNetCore.Services
{
    public class TokenService : ITokenService
    {
        private readonly IUserRepository _userRepository;

        public TokenService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public async Task<ObjectResult> Create(string email, string password, Role grantType = Role.User)
        {
            var response = IsValidCredentials(email, password);
            var passwordMatch = await response;

            if (response.IsFaulted || passwordMatch == false)
                throw new Exception(response.Exception == null
                    ? "The password is not valid"
                    : response.Exception.Message);
                    
            return new ObjectResult(await generateToken(email, grantType));
        }

        private async Task<bool> IsValidCredentials(string email, string password)
        {
            var response = _userRepository.FindByEmail(email);

            if (response.IsFaulted)
                throw new Exception("Invalid email or password");

            var user = await response;
            var passwordMatch = UserSecurity.VerifyHashedPassword(user.Password, password);

            return passwordMatch;
        }

        public RefreshToken GenerateRefreshToken(User user)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    ExpiryDate = DateTime.UtcNow.AddDays(6),
                    AddedDate = DateTime.UtcNow,
                    IsUsed = false,
                    IsRevorked = false,
                    UserId = user.ID
                };
            }
        }

        public string GenerateJwt(User user, string email, Role role = Role.User)
        {
            var claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.NameIdentifier, user.ID),
                new Claim(ClaimTypes.Hash, user.Password),
                new Claim(ClaimTypes.Role, Enum.GetName(role) ?? "User"),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp,
                    new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString())
            });

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWTSECRET") ?? string.Empty)),
                    SecurityAlgorithms.HmacSha256)
            };

            var securityToken = new JwtSecurityTokenHandler().CreateToken(tokenDescriptor);
            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }

        private async Task<dynamic> generateToken(string email, Role role)
        {
            var user = await _userRepository.FindByEmail(email);

            if (user == null) throw new Exception($"Email not found : {email}");

            var token = new SecurityToken
            {
                AccessToken = GenerateJwt(user, email, role),
                RefreshToken = GenerateRefreshToken(user)
            };

            return token;
        }
    }
}