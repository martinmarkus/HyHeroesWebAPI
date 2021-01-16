using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    [ExceptionHandler]
    public abstract class AuthorizableBaseController : ControllerBase
    {
        public Role AuthenticatedRole { get; set; }

        public IIPValidatorService IPValidatorService { get; set; }

        public ICustomAntiforgeryService CustomAntiforgeryService { get; set; }

        protected bool IsAuthenticatedAdmin
        {
            get
            {
                return AuthenticatedRole?.PermissionLevel > 1;
            }
        }

        protected IUserService UserService { get; set; }

        protected IAuthorizerService AuthorizerService { get; set; }

        public AuthorizableBaseController(
           IUserService userService,
           IAuthorizerService authorizationService,
           IIPValidatorService antiForgeryService,
           ICustomAntiforgeryService customAntiforgeryService)
        {
            UserService = userService ?? throw new ArgumentException(nameof(userService));
            AuthorizerService = authorizationService ?? throw new ArgumentException(nameof(authorizationService));
            IPValidatorService = antiForgeryService ?? throw new ArgumentException(nameof(antiForgeryService));
            CustomAntiforgeryService = customAntiforgeryService ?? throw new ArgumentException(nameof(customAntiforgeryService));
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
