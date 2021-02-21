using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class Logger : ActionFilterAttribute, IActionFilter
    {
        private readonly ILogger<object> _logger;

        public Logger(ILogger<object> logger)
        {
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            try
            {
                if (context.Result is OkObjectResult)
                {
                    var jsonResult = JsonConvert.SerializeObject((context.Result as OkObjectResult).Value);

                    _logger.LogInformation(jsonResult);
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
