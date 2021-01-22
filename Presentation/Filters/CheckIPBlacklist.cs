using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
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
                var isIPValid = await _httpCallCounterService.AddCallTryAsync(IP);

                if (!isIPValid)
                {
                    throw new IPBlacklistedException(IP);
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
