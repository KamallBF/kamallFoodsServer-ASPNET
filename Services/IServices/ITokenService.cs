using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Data.Models.Misc;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Services.IServices
{
    public interface ITokenService
    {
        public Task<ObjectResult> Create(string email, string password, Role grantType = Role.User);
        public string GenerateJwt(User user, string email, Role role = Role.User);
        public RefreshToken GenerateRefreshToken(User user);
    }
}