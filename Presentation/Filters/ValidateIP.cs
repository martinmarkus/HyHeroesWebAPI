using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ValidateIP : ActionFilterAttribute
    {
        public ValidateIP()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var assertIPValidator = context.HttpContext.Request.Headers["IP-VALIDATOR-TOKEN"].ToString();
                var userIP = context.HttpContext.Connection.RemoteIpAddress.ToString();

                var isIPValid = (context.Controller as AuthorizableBaseController).IPValidatorService
                    .ValidateToken(assertIPValidator, userIP);

                if (!isIPValid)
                {
                    throw new InvalidIPException(assertIPValidator, userIP);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                context.Result = new UnauthorizedResult();
            }

            base.OnActionExecuting(context);
        }
    }
}
