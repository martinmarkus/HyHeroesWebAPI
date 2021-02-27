using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class GameServerIntegration : ActionFilterAttribute, IActionFilter
    {
        private readonly IOptions<AppSettings> _options;

        public GameServerIntegration(IOptions<AppSettings> options)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            AuthorizableBaseController controller = default;
            try
            {
                controller = filterContext.Controller as AuthorizableBaseController;
                var integrationKey = filterContext.HttpContext.Request.Headers["INTEGRATION-KEY"].ToString();

                if (!integrationKey.Equals(_options.Value.IntegrationKey, StringComparison.OrdinalIgnoreCase))
                {
                    filterContext.Result = new UnauthorizedResult();
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
