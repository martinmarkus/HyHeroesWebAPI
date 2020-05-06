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
    public class CurrencyController : AuthorizableBaseController
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
        [ExceptionHandler]
        [HttpPost("AddKredit", Name = "addKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

            try
            {
                var newValue = await UserService.AddKreditAsync(kreditTransactionDTO);

                return Ok(new ModifiedKreditDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [ExceptionHandler]
        [HttpPost("RemoveKredit", Name = "removeKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

            try
            {
                var newValue = await UserService.RemoveKreditAsync(kreditTransactionDTO);

                return Ok(new ModifiedKreditDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("ResetKredit", Name = "resetKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

            try
            {
                var newValue = await UserService.ResetKreditAsync(kreditResetDTO.UserName);

                return Ok(new ModifiedKreditDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("AddHyCoin", Name = "addHyCoin")]
        [ProducesResponseType(typeof(int), 200)]
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

            try
            {
                return Ok(await UserService.AddHyCoinAsync(hyCoinTransactionDTO));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("RemoveHyCoin", Name = "removeHyCoin")]
        [ProducesResponseType(typeof(int), 200)]
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

            try
            {
                return Ok(await UserService.RemoveHyCoinAsync(hyCoinTransactionDTO));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("ResetHyCoin", Name = "resetHyCoin")]
        [ProducesResponseType(typeof(int), 200)]
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

            try
            {
                return Ok(await UserService.ResetHyCoinAsync(hyCoinResetDTO.UserName));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}