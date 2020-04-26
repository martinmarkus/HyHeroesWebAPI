using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    public abstract class AuthorizableControllerBase : ControllerBase
    {
        public Role AuthenticatedRole { get; set; }
        protected IUserService UserService { get; set; }
        protected IAuthorizationService AuthorizationService { get; set; }

        public AuthorizableControllerBase(
           IUserService userService,
           IAuthorizationService authorizationService)
        {
            UserService = userService ?? throw new ArgumentException(nameof(userService));
            AuthorizationService = authorizationService ?? throw new ArgumentException(nameof(authorizationService));
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public User GetAuthenticatedUser(string email) =>
            UserService.GetByEmailAsync(email).Result;

        [ApiExplorerSettings(IgnoreApi = true)]
        public bool IsSelf(string email, Guid userId) =>
           AuthorizationService.IsSelfAsync(email, userId).Result;

        [ApiExplorerSettings(IgnoreApi = true)]
        public bool HasPermission(User user, string roleName) =>
            AuthorizationService.HasPermissionAsync(user, roleName).Result;
    }
}
