using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers.WebsiteControllers
{
    [ValidateIP]
    [ServiceFilter(typeof(Logger))]
    [ServiceFilter(typeof(SessionRefresh))]
    [ValidateCustomAntiforgery]
    [Route("API/Home")]
    public class HomeController : AuthorizableBaseController
    {
        private readonly IHomeService _homeService;

        public HomeController(
            IUserService userService, 
            IAuthorizerService authorizationService, 
            IIPValidatorService antiForgeryService,
            ICustomAntiforgeryService customAntiforgeryService,
            IHomeService homeService,
            IOptions<AppSettings> appSettings) 
            : base(userService, authorizationService, antiForgeryService, customAntiforgeryService, appSettings)
        {
            _homeService = homeService ?? throw new ArgumentException(nameof(homeService));
        }

        [RequiredRole("User")]
        [HttpGet("GetHomeContent", Name = "getHomeContent")]
        [ProducesResponseType(typeof(HomeDTO), 200)]
        public async Task<IActionResult> GetHomeContentAsync()
        {
            try
            {
                return Ok(await _homeService.GetHomeContentAsync(
                    User.FindFirstValue(ClaimTypes.Name)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }
    }
}
