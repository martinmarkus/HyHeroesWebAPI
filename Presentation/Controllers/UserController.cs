﻿using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class UserController : AuthorizableControllerBase
    {
        private readonly IOptions<AppSettings> _options;
        private readonly IUserMapper _userMapper;

        public UserController(
            IOptions<AppSettings> options,
            IUserMapper userMapper,
            IUserService userService,
            IAuthorizerService authorizationService)
            : base(userService, authorizationService)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
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

            var key = _options.Value?.KreditUploadKey;

            if (!kreditTransactionDTO.KreditUploadKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid KreditUploadKey.");
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

            var key = _options.Value?.KreditUploadKey;

            if (!kreditTransactionDTO.KreditUploadKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid KreditUploadKey.");
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
            if (string.IsNullOrEmpty(kreditResetDTO.KreditUploadKey))
            {
                return Unauthorized("Invalid Kredit Upload Key.");
            }

            var key = _options.Value?.KreditUploadKey;

            if (!kreditResetDTO.KreditUploadKey.Equals(key, StringComparison.Ordinal))
            {
                return Unauthorized("Invalid Kredit Upload Key.");
            }

            await UserService.ResetKreditAsync(kreditResetDTO.UserId);

            return Ok();
        }

        [RequiredRole("User")]
        [HttpGet("GetById/{userId}", Name = "getById")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById([FromRoute] Guid userId)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            var isSelf = await AuthorizerService.IsSelfAsync(email, userId);

            if (isSelf || IsAuthenticatedAdmin)
            {
                return Ok(_userMapper.MapToUserDTO(
                    await UserService.GetByIdAsync(userId)));
            }

            return Forbid();
        }

        [RequiredRole("User")]
        [HttpGet("GetByEmail/{email}", Name = "getByEmail")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetByEmail([FromRoute] string email)
        {
            var authenticatedEmail = User.FindFirstValue(ClaimTypes.Name);
            var isSelf = authenticatedEmail.ToLower().Equals(email.ToLower(), StringComparison.OrdinalIgnoreCase);

            if (isSelf || IsAuthenticatedAdmin)
            {
                return Ok(_userMapper.MapToUserDTO(
                    await UserService.GetByEmailAsync(email)));
            }

            return Forbid();
        }
    }
}
