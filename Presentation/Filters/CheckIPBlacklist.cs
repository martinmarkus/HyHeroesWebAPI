using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class CheckIPBlacklist : ActionFilterAttribute, IActionFilter
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IHttpCallCounterService _httpCallCounterService;

        public CheckIPBlacklist(
            IOptions<AppSettings> appSettings,
            IHttpCallCounterService httpCallCounterService)
        {
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
            _httpCallCounterService = httpCallCounterService ?? throw new ArgumentException(nameof(httpCallCounterService));
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
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
