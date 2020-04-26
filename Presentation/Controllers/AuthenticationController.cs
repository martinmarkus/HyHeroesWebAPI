using System;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IAuthenticationResultDTOMapper _authenticationResultDTOMapper;
        private readonly IUserMapper _userMapper;
        private readonly IRoleRepository _roleRepository;

        public AuthenticationController(
            IAuthorizationService authorizationService,
            IAuthenticationService authenticationService,
            IAuthenticationResultDTOMapper authenticationResultDTOMapper,
            IUserMapper userMapper,
            IRoleRepository roleRepository)
        {
            _authorizationService = authorizationService ?? throw new ArgumentNullException(nameof(authorizationService));
            _authenticationService = authenticationService ?? throw new ArgumentNullException(nameof(authenticationService));
            _authenticationResultDTOMapper = authenticationResultDTOMapper ?? throw new ArgumentNullException(nameof(authenticationResultDTOMapper));
            _userMapper = userMapper ?? throw new ArgumentNullException(nameof(userMapper));
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }

        [AllowAnonymous]
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

            var user = await _authenticationService.LoginAsync(emailOrUserName, password);
            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(_authenticationResultDTOMapper.Map(user));
        }

        [AllowAnonymous]
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

            var newUser = _userMapper.MapToNewUser(newUserDTO);
            var role = await _roleRepository.GetDefaultRoleAsnyc();

            if (role == null)
            {
                return BadRequest();
            }

            var userToRegister = _userMapper.MapToUser(newUser, role.Id);

            var registeredUser = await _authenticationService.RegisterAsync(userToRegister);
            if (registeredUser == null)
            {
                return BadRequest();
            }

            return Ok(_authenticationResultDTOMapper.Map(registeredUser));
        }
    }
}
