using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ExternalAuth : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            { 
                if (!context.HttpContext.Request.Headers.ContainsKey("ExternalAuthKey"))
                {
                    throw new UnauthorizedAccessException();
                }

                var customAuthKey = context.HttpContext.Request.Headers["ExternalAuthKey"].ToString();
                var externalAuthKey = (context.Controller as AuthorizableBaseController).AppSettings.Value.ExternalAuthKey;

                if (string.IsNullOrEmpty(customAuthKey) || string.IsNullOrEmpty(externalAuthKey)
                    || !customAuthKey.Equals(externalAuthKey, StringComparison.OrdinalIgnoreCase))
                {
                    throw new UnauthorizedAccessException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
