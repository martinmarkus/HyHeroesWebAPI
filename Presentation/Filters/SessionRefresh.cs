using HyHeroesWebAPI.Presentation.Controllers;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class SessionRefresh : ActionFilterAttribute, IActionFilter
    {
        private readonly ITokenGeneratorService _tokenGeneratorService;

        public SessionRefresh(ITokenGeneratorService tokenGeneratorService)
        {
            _tokenGeneratorService = tokenGeneratorService ?? throw new ArgumentException(nameof(tokenGeneratorService));
        }

        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            try
            {
                var controller = context.Controller as AuthorizableBaseController;
                if (controller.User.Identity.IsAuthenticated)
                {
                    var userName = controller.User.FindFirstValue(ClaimTypes.Name);
                    var newSessionToken = _tokenGeneratorService.GenerateToken(userName);

                    if (!controller.Response.Headers.ContainsKey("RefreshedSessionToken"))
                    {
                        controller.Response.Headers.Add("RefreshedSessionToken", newSessionToken);
                    }
                    else
                    {
                        controller.Response.Headers["RefreshedSessionToken"] = newSessionToken;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

            await next();
        }
    }
}
