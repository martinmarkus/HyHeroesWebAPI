using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    [ServiceFilter(typeof(ExceptionHandler))]
    [ServiceFilter(typeof(CheckIPBlacklist))]
    public abstract class AuthorizableBaseController : ControllerBase
    {
        public Role AuthenticatedRole { get; set; }

        public IOptions<AppSettings> AppSettings { get; set; }

        public IIPValidatorService IPValidatorService { get; set; }

        public ICustomAntiforgeryService CustomAntiforgeryService { get; set; }

        protected bool IsAuthenticatedAdmin
        {
            get
            {
                return AuthenticatedRole?.PermissionLevel > 1;
            }
        }

        public IUserService UserService { get; set; }

        protected IAuthorizerService AuthorizerService { get; set; }

        protected AuthorizableBaseController(
           IUserService userService,
           IAuthorizerService authorizationService,
           IIPValidatorService antiForgeryService,
           ICustomAntiforgeryService customAntiforgeryService,
           IOptions<AppSettings> appSettings)
        {
            UserService = userService ?? throw new ArgumentException(nameof(userService));
            AuthorizerService = authorizationService ?? throw new ArgumentException(nameof(authorizationService));
            IPValidatorService = antiForgeryService ?? throw new ArgumentException(nameof(antiForgeryService));
            CustomAntiforgeryService = customAntiforgeryService ?? throw new ArgumentException(nameof(customAntiforgeryService));

            AppSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public User GetAuthenticatedUser(string userName) =>
            UserService.GetByUserNameAsync(userName).Result;

        [ApiExplorerSettings(IgnoreApi = true)]
        public bool IsSelf(string email, Guid userId) =>
           AuthorizerService.IsSelfAsync(email, userId).Result;

        [ApiExplorerSettings(IgnoreApi = true)]
        public bool HasPermission(User user, string roleName) =>
            AuthorizerService.HasPermissionAsync(user, roleName).Result;
    }
}
