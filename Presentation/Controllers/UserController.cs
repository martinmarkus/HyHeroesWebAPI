using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            IUserMapper userMapper,
            IUserService userService,
            IAuthorizerService authorizerService,
            IIPValidatorService IPValidatorService,
            ICustomAntiforgeryService customAntiforgeryService,
            IOptions<AppSettings> appSettings)
            : base(userService, authorizerService, IPValidatorService, customAntiforgeryService, appSettings)
        {
            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpPost("UpdateUser", Name = "UpdateUser")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDTO userDTO)
        {
            try
            {
                await UserService.UpdateUserAsync(userDTO);
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpGet("VerifyPassword", Name = "verifyPassword")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPasswordAsync([FromBody] VerifyPasswordDTO verifyPasswordDTO)
        {
            try
            {
                await _userService.VerifyPasswordAsync(
                    User.FindFirstValue(ClaimTypes.Name),
                    verifyPasswordDTO.Password);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpGet("GetByUserNameOrEmail/{userNameOrEmail}", Name = "getByUserNameOrEmail")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetByUserNameOrEmail([FromRoute] string userNameOrEmail)
        {
            try
            {
                if (string.IsNullOrEmpty(userNameOrEmail))
                {
                    return BadRequest();
                }

                return Ok(await UserService.GetByUserNameOrEmailAsync(userNameOrEmail));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpGet("GetSelf", Name = "getSelf")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetSelf()
        {
            try
            {
                var user = await UserService.GetByUserNameAsync(User.FindFirstValue(ClaimTypes.Name));
                if (user == null)
                {
                    throw new NotFoundException();
                }

                var userDTO = _userMapper.MapToAuthenticatedUserDTO(user);

                var identity = await UserService.GenerateNewClientIdentityValuesAsync(user.UserName);
                HttpContext.Response.Headers.Add("htozygkkkc", identity.BaseValue);
                HttpContext.Response.Headers.Add("xo42atufxn", identity.ValidatorHash);

                return Ok(user);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpPost("ChangePassword", Name = "changePassword")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
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
                    changePasswordDTO.OldPassword,
                    changePasswordDTO.NewPassword);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpPost("BanUser", Name = "banUser")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
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

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpGet("GetToplist", Name = "getToplist")]
        [ProducesResponseType(typeof(IList<ToplistElementDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetToplist()
        {
            try
            {
                return Ok(await UserService.GetTopListAsync());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpGet("GetAllRoles", Name = "getAllRoles")]
        [ProducesResponseType(typeof(IList<RoleDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllRoles()
        {
            try
            {
                return Ok(await UserService.GetAllRolesAsync());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpPost("SendEmailVerifyCode", Name = "sendEmailVerifyCode")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> SendEmailVerifyCode(VerifyEmailDTO verifyEmailDTO)
        {
            try
            {
                await UserService.SendEmailVerifyCodeAsync(
                    User.FindFirstValue(ClaimTypes.Name),
                    verifyEmailDTO.EmailToVerify);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("VerifyEmail/{activationCode}", Name = "verifyEmail")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> SendVerifyEmailEmailVerifyCode([Required][FromRoute] Guid activationCode)
        {
            try
            {
                await UserService.VerifyEmailAsync(activationCode);

                return Redirect(AppSettings.Value.EmailVerifyMailOptions.VerificationSuccessRedirect);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Redirect(AppSettings.Value.EmailVerifyMailOptions.VerificationFailRedirect);
            }
        }

        [AllowAnonymous]
        [HttpGet("SendPasswordResetEmail/{emailOrUserName}", Name = "sendPasswordResetEmail")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> SendPasswordResetEmailAsync([Required][FromRoute] string emailOrUserName)
        {
            try
            {
                await UserService.SendPasswordResetEmailAsync(emailOrUserName);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("CheckResetCode/{resetCode}", Name = "checkResetCode")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> CheckResetCodeAsync([Required][FromRoute] Guid resetCode)
        {
            try
            {
                var isCodeValid = await UserService.CheckResetCodeAsync(resetCode);

                if (isCodeValid)
                {
                    return Redirect(
                        AppSettings.Value.PasswordResetMailOptions.PasswordResetSuccessRedirect
                        .Replace("{resetCode}", resetCode.ToString()));
                }

                return Redirect(AppSettings.Value.PasswordResetMailOptions.PasswordResetFailRedirect);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Redirect(AppSettings.Value.PasswordResetMailOptions.PasswordResetFailRedirect);
            }
        }

        [AllowAnonymous]
        [HttpPost("ResetPassword", Name = "resetPassword")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetPasswordAsync(
            [FromBody] ResetForgottenPasswordDTO resetForgottenPasswordDTO)
        {
            try
            {
                await UserService.ResetPasswordAsync(resetForgottenPasswordDTO);
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("GetUserNameByPasswordResetCode/{resetCode}", Name = "getUserNameByPasswordResetCode")]
        [ProducesResponseType(typeof(UserNameDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUserNameByPasswordResetCodeAsync([Required][FromRoute] Guid resetCode)
        {
            try
            {
                return Ok(await UserService.GetUserNameByPasswordResetCodeAsync(resetCode));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("GetRegisteredUserCount", Name = "getRegisteredUserCount")]
        [ProducesResponseType(typeof(RegisteredUserCountDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetRegisteredUserCountAsync()
        {
            try
            {
                return Ok(await UserService.GetRegisteredUserCountAsync());
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpPost("UpdateServerPlayerState", Name = "updateServerPlayerState")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateServerPlayerStateAsync([FromBody] ServerPlayerStateDTO serverPlayerStateDTO)
        {
            try
            {
                await UserService.UpdateServerPlayerStateAsync(serverPlayerStateDTO);
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("GetOnlinePlayerCount", Name = "getOnlinePlayerCount")]
        [ProducesResponseType(typeof(OnlinePlayerCountDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOnlinePlayerCountAsync()
        {
            try
            {
                return Ok(await UserService.GetOnlinePlayerCountAsync());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpPost("ResetPlayerStates", Name = "resetPlayerStates")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetPlayerStatesAsync()
        {
            try
            {
                await UserService.ResetPlayerStatesAsync();
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
