using System;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    public class AuthenticationController : AuthorizableBaseController
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserMapper _userMapper;
        private readonly IRoleRepository _roleRepository;
        private readonly IHttpContextAccessor _accessor;
        public AuthenticationController(
            IAuthenticationService authenticationService,
            IUserMapper userMapper,
            IRoleRepository roleRepository,
            IUserService userService,
            IAuthorizerService authorizerService,
            IHttpContextAccessor accessor)
            : base(userService, authorizerService)
        {

            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _userMapper = userMapper ?? throw new ArgumentNullException(nameof(userMapper));
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
            _accessor = accessor ?? throw new ArgumentNullException(nameof(accessor));
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpPost("Login", Name = "login")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            User user;
            try
            {
                user = await _authenticationService.LoginAsync(
                    new LoginUser()
                    {
                        EmailOrUserName = loginDTO.EmailOrUserName,
                        Password = loginDTO.Password,
                        LastAuthenticationIp = HttpContext.Connection.RemoteIpAddress.ToString(),
                        LastAuthenticationDate = DateTime.Now.ToString()
                    });

                if (user == null)
                {
                    return Unauthorized();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            SignOut();
            return Ok(_userMapper.MapToAuthenticatedUserDTO(user));
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpPost("Register", Name = "register")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Register([FromBody] NewUserDTO newUserDTO)
        {
            if (!ModelState.IsValid || newUserDTO == null)
            {
                return BadRequest();
            }

            User registeredUser;
            try
            {
                var role = await _roleRepository.GetDefaultRoleAsnyc();
                if (role == null)
                {
                    return BadRequest();
                }

                var newUser = _userMapper.MapToNewUser(newUserDTO);
                var userToRegister = _userMapper.MapToUser(newUser, role.Id);

                userToRegister.LastAuthenticationIp = HttpContext.Connection.RemoteIpAddress.ToString();
                userToRegister.LastAuthenticationDate = DateTime.Now;

                registeredUser = await _authenticationService.RegisterAsync(userToRegister);
                if (registeredUser == null)
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Ok(_userMapper.MapToAuthenticatedUserDTO(registeredUser));
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpPost("RegisterWithouthEmail", Name = "registerWithouthEmail")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Register([FromBody] NewUserWithoutEmailDTO newUserWithoutEmailDTO)
        {
            if (!ModelState.IsValid || newUserWithoutEmailDTO == null)
            {
                return BadRequest();
            }

            User registeredUser;
            try
            {
                var role = await _roleRepository.GetDefaultRoleAsnyc();
                if (role == null)
                {
                    return BadRequest();
                }

                var newUser = _userMapper.MapToNewUser(newUserWithoutEmailDTO);
                var userToRegister = _userMapper.MapToUser(newUser, role.Id);

                userToRegister.LastAuthenticationIp = HttpContext.Connection.RemoteIpAddress.ToString();
                userToRegister.LastAuthenticationDate = DateTime.Now;

                registeredUser = await _authenticationService.RegisterAsync(userToRegister);
                if (registeredUser == null)
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Ok(_userMapper.MapToAuthenticatedUserDTO(registeredUser));
        }
    }
}
