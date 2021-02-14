using HyHeroesWebAPI.Presentation.Controllers;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Security.Claims;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class SessionRefresh : ActionFilterAttribute, IActionFilter
    {
        private readonly ITokenGeneratorService _tokenGeneratorService;

        public SessionRefresh(ITokenGeneratorService tokenGeneratorService)
        {
            _tokenGeneratorService = tokenGeneratorService ?? throw new ArgumentException(nameof(tokenGeneratorService));
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            try
            {
                var controller = context.Controller as AuthorizableBaseController;
                if (controller.User.Identity.IsAuthenticated)
                {
                    var newSessionToken = _tokenGeneratorService.GenerateToken(controller.User.FindFirstValue(ClaimTypes.Name));
                    
                    if (controller.Response.Headers.ContainsKey("RefreshedSessionToken"))
                    {
                        controller.Response.Headers.Add("RefreshedSessionToken", newSessionToken);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
