using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class WoodcraftMigrationController : AuthorizableBaseController
    {
        private readonly IWoodcraftMigrationService _woodcraftMigrationService;

        public WoodcraftMigrationController(
            IWoodcraftMigrationService woodcraftMigrationService,
            IUserService userService,
            IAuthorizerService authorizationService,
            IIPValidatorService antiForgeryService,
            ICustomAntiforgeryService customAntiforgeryService, 
            IOptions<AppSettings> appSettings) 
            : base(userService, authorizationService, antiForgeryService, customAntiforgeryService, appSettings)
        {
            _woodcraftMigrationService = woodcraftMigrationService ?? throw new ArgumentException(nameof(woodcraftMigrationService));
        }

        [AllowAnonymous]
        [HttpPost("ValidateWoodcraftUser", Name = "validateWoodcraftUser")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ValidateWoodcraftUserAsync(WoodcraftUserDTO woodcraftUserDTO)
        {
            try
            {
                // INFO: Custom woodcraft auth
                if (string.IsNullOrEmpty(woodcraftUserDTO.WoodcraftMigrationKey) 
                    || !AppSettings.Value.WoodcraftMigrationKey.Equals(
                    woodcraftUserDTO.WoodcraftMigrationKey,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new UnauthorizedAccessException();
                }

                await _woodcraftMigrationService.ValidateWoodcraftUserAsync(woodcraftUserDTO, HttpContext.Connection.RemoteIpAddress.ToString());

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [AllowAnonymous]
        [HttpPost("ValidateWoodcraftUserRange", Name = "validateWoodcraftUserRange")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ValidateWoodcraftUserRangeAsync(WoodcraftUserListDTO woodcraftUserListDTO)
        {
            try
            {
                // INFO: Custom woodcraft auth
                if (string.IsNullOrEmpty(woodcraftUserListDTO.WoodcraftMigrationKey)
                    || !AppSettings.Value.WoodcraftMigrationKey.Equals(
                    woodcraftUserListDTO.WoodcraftMigrationKey,
                    StringComparison.OrdinalIgnoreCase))
                {
                    throw new UnauthorizedAccessException();
                }

                await _woodcraftMigrationService.ValidateWoodcraftUserRangeAsync(woodcraftUserListDTO, HttpContext.Connection.RemoteIpAddress.ToString());

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
