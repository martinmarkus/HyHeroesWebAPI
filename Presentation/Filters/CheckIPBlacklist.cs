using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;
using System.Threading.Tasks;
namespace HyHeroesWebAPI.Presentation.Filters
{
    public class CheckIPBlacklist : ActionFilterAttribute, IActionFilter
    {
        private readonly IHttpCallCounterService _httpCallCounterService;

        public CheckIPBlacklist(IHttpCallCounterService httpCallCounterService)
        {
            _httpCallCounterService = httpCallCounterService ?? throw new ArgumentException(nameof(httpCallCounterService));
        }

        public async override Task OnActionExecutionAsync(
            ActionExecutingContext context,
            ActionExecutionDelegate next)
        {
            try
            {
                var IP = context.HttpContext.Connection.RemoteIpAddress.ToString();

                var isBanned = await _httpCallCounterService.IsBannedAsync(IP);
                if (isBanned)
                {
                    context.Result = new ObjectResult(context.ModelState)
                    {
                        StatusCode = StatusCodes.Status403Forbidden
                    };
                }

                var isIPValid = await _httpCallCounterService.AddCallTryAsync(IP);

                if (!isIPValid)
                {
                    context.Result = new ObjectResult(context.ModelState)
                    {
                        StatusCode = StatusCodes.Status403Forbidden
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            await next();
        }
    }
}
