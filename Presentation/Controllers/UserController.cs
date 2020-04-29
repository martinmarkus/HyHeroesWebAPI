using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
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
        private readonly IUserMapper _userMapper;
        private readonly IUserService _userService;

        public UserController(
            IOptions<AppSettings> options,
            IUserMapper userMapper,
            IUserService userService,
            IAuthorizerService authorizationService)
            : base(userService, authorizationService)
        {
            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
        }

        [RequiredRole("Admin")]
        [HttpGet("GetById/{userId}", Name = "getById")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById([FromRoute] Guid userId) =>
            Ok(_userMapper.MapToUserDTO(
                await UserService.GetByIdAsync(userId)));

        [RequiredRole("Admin")]
        [HttpGet("GetByEmail/{email}", Name = "getByEmail")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetByEmail([FromRoute] string email) =>
            Ok(_userMapper.MapToUserDTO(
                await UserService.GetByEmailAsync(email)));

        [RequiredRole("Admin")]
        [HttpGet("GetByUserName/{userName}", Name = "getByUserName")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetByUserName([FromRoute] string userName) =>
            Ok(_userMapper.MapToUserDTO(
                await UserService.GetByUserNameAsync(userName)));

        [RequiredRole("User")]
        [HttpGet("GetSelf", Name = "getSelf")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetSelf() =>
             Ok(_userMapper.MapToUserDTO(
                await UserService.GetByEmailAsync(
                User.FindFirstValue(ClaimTypes.Name))));

        [RequiredRole("User")]
        [HttpGet("ChangePassword", Name = "changePassword")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateSelf([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _userService.ChangePasswordAsync(
                User.FindFirstValue(ClaimTypes.Name),
                changePasswordDTO.NewPassword);

            return Ok();
        }
    }
}
