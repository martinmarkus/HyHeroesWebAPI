using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Security.Claims;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class RequiredRole : ActionFilterAttribute, IActionFilter
    {
        private readonly string _roleName;

        public RequiredRole(string roleName)
        {
            _roleName = roleName ?? throw new ArgumentException(nameof(roleName));
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            AuthorizableControllerBase controller = default;
            try
            {
                controller = filterContext.Controller as AuthorizableControllerBase;

                var email = controller.User.FindFirstValue(ClaimTypes.Name);
                var user = controller.GetAuthenticatedUser(email);
                controller.AuthenticatedRole = user.Role;
                var hasPermission = controller.HasPermission(user, _roleName);

                if (!hasPermission)
                {
                    filterContext.Result = new ForbidResult();
                    return;
                }
            }
            catch (Exception)
            {
                filterContext.Result = new ForbidResult();
                return;
            }
        }
    }
}
