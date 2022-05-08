using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Misc;
using Kamall_foods_server_aspNetCore.Repository;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers
{
    [ApiController]
    [Route("Auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;

        private static ReadOnlyCollection<string> AuthorizedEmails =>
            new List<string> {"dyiemboiro@gmail.com"}.AsReadOnly();

        public AuthController(IUserRepository userRepository, IUserService userService)
        {
            _userService = userService;
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("test")]
        public ActionResult Test()
        {
            return Ok("it works");
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> LoginUser(UserLoginRequest user)
        {
            var response = _userService.Authenticate(user);

            if (response.IsFaulted)
                return StatusCode(404, new ErrorMessage
                {
                    Error = response.Exception?.Message
                });

            var isAdmin = AuthorizedEmails.Any(email => email.Equals(user.Email.ToLower()));
            if (isAdmin) response = _userService.Authenticate(user, Role.SuperAdmin);

            /**
             * Update when User is logged in 
             */
            var securityTokenResult = await response;
            var securityToken = (SecurityToken) securityTokenResult.Value;

            var updatedUser = await _userRepository.Find(securityToken.RefreshToken.UserId);

            if (updatedUser.IsVerified == false)
                return StatusCode(400, new
                {
                    Error = "This account is not verified yet, please check your mailbox"
                });

            updatedUser.UpdatedAt = DateTime.UtcNow;
            updatedUser.RefreshToken = securityToken.RefreshToken.Token;

            await _userRepository.Update(updatedUser.ID, updatedUser);
            /** **/

            Response.Cookies.Append("X-Access-Token", securityToken.AccessToken,
                new CookieOptions()
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                    Path = "/",
                    Expires = DateTimeOffset.Now.AddDays(1),
                    IsEssential = true
                });
            Response.Cookies.Append("X-Username", updatedUser.ID,
                new CookieOptions()
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                    Path = "/"
                });
            Response.Cookies.Append("X-Refresh-Token", securityToken.RefreshToken.Token,
                new CookieOptions()
                {
                    HttpOnly = true,
                    SameSite = SameSiteMode.None,
                    Secure = true,
                    Path = "/",
                    Expires = securityToken.RefreshToken.ExpiryDate
                });

            return Ok("Successfully authenticated");
        }

        [Authorize]
        [HttpPost]
        [Route("logout")]
        public ActionResult LogoutUser()
        {
            var response = _userService.Logout(HttpContext);

            if (response.IsFaulted) return BadRequest("Unable to log out");

            return Ok("Logged out successfully");
        }
    }
}