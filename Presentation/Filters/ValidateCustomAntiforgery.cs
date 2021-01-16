using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ValidateCustomAntiforgery : ActionFilterAttribute
    {
        public ValidateCustomAntiforgery()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var baseAntiforgeryValue = context.HttpContext.Request.Headers["XSS-BASE-VALUE"].ToString();
                var baseAntiforgeryKey = context.HttpContext.Request.Headers["XSS-BASE-KEY"].ToString();
                var encryptedAntiforgery = context.HttpContext.Request.Headers["XSS-ENCRYPT"].ToString();

                var isAntiforgeryValid = (context.Controller as AuthorizableBaseController).CustomAntiforgeryService
                    .Validate(baseAntiforgeryValue, baseAntiforgeryKey, encryptedAntiforgery);

                if (!isAntiforgeryValid)
                {
                    throw new InvalidCustomAntiforgeryException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
