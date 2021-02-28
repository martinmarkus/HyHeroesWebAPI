using System;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using HyHeroesWebAPI.Presentation.Filters;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [AllowAnonymous]
    [ServiceFilter(typeof(Logger))]
    [Route("API/Authentication")]
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
            IAuthorizerService authorizerService,
            IIPValidatorService IPValidatorService,
            ICustomAntiforgeryService customAntiforgeryService,
            IOptions<AppSettings> appSettings)
            : base(userService, authorizerService, IPValidatorService, customAntiforgeryService, appSettings)
        {
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _userMapper = userMapper ?? throw new ArgumentNullException(nameof(userMapper));
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }

        [HttpPost("Login", Name = "login")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var user = await _authenticationService.LoginAsync(
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

                var identity = await UserService.GenerateNewClientIdentityValuesAsync(user.UserName);
                Response.Headers.Add("htozygkkkc", identity.BaseValue);
                Response.Headers.Add("xo42atufxn", identity.ValidatorHash);

                return Ok(_userMapper.MapToAuthenticatedUserDTO(user));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost("Register", Name = "register")]
        [ProducesResponseType(typeof(AuthenticatedUserDTO), 200)]
        public async Task<IActionResult> Register([FromBody] NewUserDTO newUserDTO)
        {
            if (!ModelState.IsValid || newUserDTO == null)
            {
                return BadRequest();
            }

            try
            {
                var role = await _roleRepository.GetDefaultRoleAsnyc();
                if (role == null)
                {
                    return BadRequest();
                }

                var ip = HttpContext.Connection.RemoteIpAddress.ToString();
                var newUser = _userMapper.MapToNewUser(newUserDTO);
                var userToRegister = _userMapper.MapToNewRegisterUser(newUser, role.Id, ip);

                var registeredUser = await _authenticationService.RegisterAsync(userToRegister);

                var identity = await UserService.GenerateNewClientIdentityValuesAsync(newUserDTO.UserName);
                Response.Headers.Add("htozygkkkc", identity.BaseValue);
                Response.Headers.Add("xo42atufxn", identity.ValidatorHash);

                return Ok(_userMapper.MapToAuthenticatedUserDTO(registeredUser));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
