using System;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class CurrencyController : AuthorizableControllerBase
    {
        private readonly IOptions<AppSettings> _options;

        public CurrencyController(
            IOptions<AppSettings> options,
            IUserService userService,
            IAuthorizerService authorizationService)
            : base(userService, authorizationService)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
        }

        [RequiredRole("Admin")]
        [HttpPost("AddKredit", Name = "addKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddKredit([FromBody] KreditTransactionDTO kreditTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var key = _options.Value?.SecretAdminKey;

            if (!kreditTransactionDTO.SecretAdminKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            await UserService.AddKreditAsync(kreditTransactionDTO);

            return Ok();
        }

        [RequiredRole("Admin")]
        [HttpPost("RemoveKredit", Name = "removeKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveKredit([FromBody] KreditTransactionDTO kreditTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var key = _options.Value?.SecretAdminKey;

            if (!kreditTransactionDTO.SecretAdminKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            await UserService.RemoveKreditAsync(kreditTransactionDTO);

            return Ok();
        }

        [RequiredRole("Admin")]
        [HttpPost("ResetKredit", Name = "resetKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetKredit([FromBody] KreditResetDTO kreditResetDTO)
        {
            if (string.IsNullOrEmpty(kreditResetDTO.SecretAdminKey))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            var key = _options.Value?.SecretAdminKey;

            if (!kreditResetDTO.SecretAdminKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            await UserService.ResetKreditAsync(kreditResetDTO.UserName);

            return Ok();
        }

        [RequiredRole("Admin")]
        [HttpPost("AddHyCoin", Name = "addHyCoin")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddHyCoin([FromBody] HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var key = _options.Value?.SecretAdminKey;

            if (!hyCoinTransactionDTO.SecretAdminKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            await UserService.AddHyCoinAsync(hyCoinTransactionDTO);

            return Ok();
        }

        [RequiredRole("Admin")]
        [HttpPost("RemoveHyCoin", Name = "removeHyCoin")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveHyCoin([FromBody] HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var key = _options.Value?.SecretAdminKey;

            if (!hyCoinTransactionDTO.SecretAdminKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            await UserService.RemoveHyCoinAsync(hyCoinTransactionDTO);

            return Ok();
        }

        [RequiredRole("Admin")]
        [HttpPost("ResetHyCoin", Name = "resetHyCoin")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetHyCoin([FromBody] HyCoinResetDTO hyCoinResetDTO)
        {
            if (string.IsNullOrEmpty(hyCoinResetDTO.SecretAdminKey))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            var key = _options.Value?.SecretAdminKey;

            if (!hyCoinResetDTO.SecretAdminKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid SecretAdminKey.");
            }

            await UserService.ResetHyCoinAsync(hyCoinResetDTO.UserName);

            return Ok();
        }
    }
}