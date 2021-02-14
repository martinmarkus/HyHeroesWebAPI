using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ValidateCustomAntiforgery : ActionFilterAttribute
    {
        public ValidateCustomAntiforgery()
        {
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            try
            {
                var baseController = (context.Controller as AuthorizableBaseController);
                var appSettings = baseController.AppSettings.Value;

                var baseValue = context.HttpContext.Request.Headers["LZM33EUZZBHMTHEXGOYH"].ToString();
                var encryptedValue = context.HttpContext.Request.Headers["BRABLYKGJHXK8HK470EK"].ToString();

                var clientIdentity = await baseController.UserService.GetIdentityByTokenValuesAsync(baseValue, encryptedValue);

                if (clientIdentity == null)
                {
                    throw new InvalidCustomAntiforgeryException();
                }

                var isAntiforgeryValid = baseController.CustomAntiforgeryService.Validate(
                    baseValue,
                    encryptedValue,
                    clientIdentity.ValidatorSalt);

                if (!isAntiforgeryValid)
                {
                    throw new InvalidCustomAntiforgeryException();
                }

                if (clientIdentity.ExpirationDate.AddMinutes(-10) < DateTime.Now)
                {
                    clientIdentity = await baseController.UserService.GenerateNewClientIdentityValuesAsync(clientIdentity);
                }

                context.HttpContext.Response.Headers.Add("htozygkkkc", clientIdentity.BaseValue);
                context.HttpContext.Response.Headers.Add("xo42atufxn", clientIdentity.ValidatorHash);

                await next();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
