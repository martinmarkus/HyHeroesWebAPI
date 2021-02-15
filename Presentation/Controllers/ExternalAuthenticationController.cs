using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class ExternalAuthenticationController : AuthorizableBaseController
    {
        private readonly IExternalAuthenticationService _externalAuthService;

        public ExternalAuthenticationController(
            IExternalAuthenticationService externalAuthService,
            IUserService userService,
            IAuthorizerService authorizationService,
            IIPValidatorService antiForgeryService,
            ICustomAntiforgeryService customAntiforgeryService, 
            IOptions<AppSettings> appSettings) 
            : base(userService, authorizationService, antiForgeryService, customAntiforgeryService, appSettings)
        {
            _externalAuthService = externalAuthService ?? throw new ArgumentException(nameof(externalAuthService));
        }

        [AllowAnonymous]
        [ExternalAuth]
        [HttpPost("ValidateAuthenticationByExternalSystem", Name = "validateAuthenticationByExternalSystem")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> ValidateAuthenticationByExternalSystemAsync(ValidateAuthenticationByExternalDTO authDTO)
        {
            try
            {
                await _externalAuthService.ValidateExternalAuthenticationAsync(
                    authDTO,
                    HttpContext.Connection.RemoteIpAddress.ToString());

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [AllowAnonymous]
        [ExternalAuth]
        [HttpPost("ValidateAuthenticationByExternalSystemRange", Name = "validateAuthenticationByExternalSystemRange")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> ValidateAuthenticationByExternalSystemRangeAsync(ValidateAuthenticationByExternalListDTO authDTO)
        {
            try
            {
                await _externalAuthService.ValidateExternalAuthenticationRangeAsync(
                    authDTO,
                    HttpContext.Connection.RemoteIpAddress.ToString());

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }
    }
}
