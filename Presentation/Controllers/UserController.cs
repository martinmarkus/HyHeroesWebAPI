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
    public class UserController : AuthorizableBaseController
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
        [ExceptionHandler]
        [HttpGet("GetById/{userId}", Name = "getById")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetById([FromRoute] Guid userId)
        {
            try
            {
                return Ok(_userMapper.MapToUserDTO(
                    await UserService.GetByIdAsync(userId)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetByEmail/{email}", Name = "getByEmail")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetByEmail([FromRoute] string email)
        {
            try
            {
                return Ok(_userMapper.MapToUserDTO(
                    await UserService.GetByEmailAsync(email)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetByUserName/{userName}", Name = "getByUserName")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetByUserName([FromRoute] string userName)
        {
            try
            {
                return Ok(_userMapper.MapToUserDTO(
                    await UserService.GetByUserNameAsync(userName)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }     

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpGet("GetSelf", Name = "getSelf")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetSelf()
        {
            try
            {
                return Ok(_userMapper.MapToUserDTO(
                    await UserService.GetByEmailAsync(
                    User.FindFirstValue(ClaimTypes.Name))));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpPost("ChangePassword", Name = "changePassword")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _userService.ChangePasswordAsync(
                    User.FindFirstValue(ClaimTypes.Name),
                    changePasswordDTO.NewPassword);

                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("BanUser", Name = "banUser")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> BanUser([FromBody] BanUserDTO banUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _userService.BanUserAsync(banUserDTO);

                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
