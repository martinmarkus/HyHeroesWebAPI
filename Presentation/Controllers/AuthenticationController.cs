using System;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    public class AuthenticationController : AuthorizableBaseController
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserMapper _userMapper;
        private readonly IRoleRepository _roleRepository;

        public AuthenticationController(
            IAuthenticationService authenticationService,
            IUserMapper userMapper,
            IRoleRepository roleRepository,
            IUserService userService,
            IAuthorizerService authorizerService)
            : base(userService, authorizerService)
        {

            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _userMapper = userMapper ?? throw new ArgumentNullException(nameof(userMapper));
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpPost("Login", Name = "login")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Login(
            [FromHeader(Name = "emailOrUserName")] string emailOrUserName,
            [FromHeader(Name = "password")] string password)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (string.IsNullOrEmpty(emailOrUserName) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            User user;
            try
            {
                user = await _authenticationService.LoginAsync(emailOrUserName, password);
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
                var newUser = _userMapper.MapToNewUser(newUserDTO);
                var role = await _roleRepository.GetDefaultRoleAsnyc();

                if (role == null)
                {
                    return BadRequest();
                }

                var userToRegister = _userMapper.MapToUser(newUser, role.Id);

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
