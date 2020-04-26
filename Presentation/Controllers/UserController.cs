using HyHeroesWebAPI.Presentation.Attributes;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ControllerName("Users")]
    [Authorize]
    public class UserController : AuthorizableControllerBase
    {
        private readonly IOptions<AppSettings> _options;
        private readonly IUserMapper _userMapper;

        public UserController(
            IOptions<AppSettings> options,
            IUserService userService,
            Services.Interfaces.IAuthorizationService authorizationService,
            IUserMapper userMapper)
            : base(userService, authorizationService)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
        }

        [AllowAnonymous]
        [HttpPost("AddKredit", Name = "addKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddKredit([FromBody]KreditTransactionDTO kreditUploadDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var key = _options.Value?.KreditUploadKey;

            if (!kreditUploadDTO.KreditUploadKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid KreditUploadKey.");
            }

            await UserService.AddKreditAsync(kreditUploadDTO);

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("RemoveKredit", Name = "removeKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveKredit([FromBody]KreditTransactionDTO kreditUploadDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var key = _options.Value?.KreditUploadKey;

            if (!kreditUploadDTO.KreditUploadKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid KreditUploadKey.");
            }

            await UserService.RemoveKreditAsync(kreditUploadDTO);

            return Ok();
        }

        [AllowAnonymous]
        [HttpPost("ResetKredit/{userId}", Name = "resetKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetKredit([FromRoute]Guid userId, string KreditUploadKey)
        {
            if (string.IsNullOrEmpty(KreditUploadKey))
            {
                return Unauthorized("Invalid Kredit Upload Key.");
            }

            var key = _options.Value?.KreditUploadKey;

            if (!KreditUploadKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid Kredit Upload Key.");
            }

            await UserService.ResetKreditAsync(userId);

            return Ok();
        }

        [RequiredRole(typeof(UserController), "Admin")]
        [HttpGet("GetById/{userId}", Name = "getById")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById([FromRoute]Guid userId)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            var user = await UserService.GetByEmailAsync(email);

            var isSelf = await AuthorizationService.IsSelfAsync(email, userId);
            if (isSelf)
            {
                return Ok(_userMapper.MapToUserDTO(user));
            }

            return Forbid();
        }
    }
}
