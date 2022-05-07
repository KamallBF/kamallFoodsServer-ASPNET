using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.CacheSystem;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Services.Email;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers
{
    [ApiController]
    [Route("Restaurants")]
    public class RestaurantController : ControllerBase
    {
        private readonly ICacheSystem _cacheSystem;
        private readonly IEmailService _emailService;

        public RestaurantController(ICacheSystem cacheSystem, IEmailService emailService)
        {
            _cacheSystem = cacheSystem;
            _emailService = emailService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> CreateAccountRequest(RestaurantAdminCreateRequest request)
        {
            try
            {
                await _emailService.RestaurantManagerCreationValidation(request);
                return Ok($"Confirmation email sent with success to {request.Email}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}