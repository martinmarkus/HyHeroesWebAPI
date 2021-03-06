using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services;
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
    [Route("API/KreditUpload")]
    public class KreditUploadController : AuthorizableBaseController
    {
        private readonly IKreditUploadService _kreditUploadService;

        public KreditUploadController(
            IUserService userService,
            IAuthorizerService authorizationService,
            IIPValidatorService antiForgeryService,
            ICustomAntiforgeryService customAntiforgeryService,
            IKreditUploadService kreditUploadService,
            IOptions<AppSettings> appSettings) 
            : base(userService, authorizationService, antiForgeryService, customAntiforgeryService, appSettings)
        {
            _kreditUploadService = kreditUploadService ?? throw new ArgumentException(nameof(kreditUploadService));
        }

        [RequiredRole("User")]
        [HttpGet("GetKreditUploadData", Name = "getKreditUploadData")]
        [ProducesResponseType(typeof(KreditUploadDTO), 200)]
        public async Task<IActionResult> GetHomeContentAsync()
        {
            try
            {
                return Ok(await _kreditUploadService.GetKreditUploadDataAsync(
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
