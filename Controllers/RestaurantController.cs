using System;
using System.Threading.Tasks;
using Kamall_foods_server_aspNetCore.Data.CacheSystem;
using Kamall_foods_server_aspNetCore.Data.Models;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Kamall_foods_server_aspNetCore.Controllers;

[ApiController]
[Route("Restaurants")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantAdminRepository _adminRepository;
    private readonly ICacheSystem _cacheSystem;
    private readonly IEmailService _emailService;
    private readonly IRestaurantAdminService _restaurantAdminService;

    public RestaurantController(ICacheSystem cacheSystem, IEmailService emailService,
        IRestaurantAdminRepository restaurantAdminRepository,
        IRestaurantAdminService restaurantAdminService)
    {
        _cacheSystem = cacheSystem;
        _emailService = emailService;
        _adminRepository = restaurantAdminRepository;
        _restaurantAdminService = restaurantAdminService;
    }

    [HttpPost]
    [Route("register")]
    public async Task<ActionResult> CreateAccountRequest(RestaurantAdminCreateRequest request)
    {
        try
        {
            await _adminRepository.Create(request);
            await _emailService.RestaurantManagerCreationValidation(request);
            await _restaurantAdminService.SendRegisteringRequestEmail(request);
            return Ok($"Confirmation email sent with success to {request.Email}");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    [Route("validate/admin/{id}")]
    public async Task<ActionResult> ApproveCreationRequest(string id)
    {
        try
        {
            await _restaurantAdminService.Approve(id);
            // Envoyer un mail d'approbationn au client lorsqu'il l'est
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = 200,
                Content = "Création de compte professionelle approuvée !"
            };
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPost]
    [Route("invalidate/admin/{id}")]
    public async Task<ActionResult> DisapproveCreationRequest(string id)
    {
        try
        {
            await _restaurantAdminService.DisapproveAndDelete(id);
            //Envoyer un mail de refus
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = 200,
                Content = "Demande de création de compte refusée avec succès !"
            };
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}