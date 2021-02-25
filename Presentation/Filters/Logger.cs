using HyHeroesWebAPI.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
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

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            try
            {
                if (context.Controller is AuthorizableBaseController)
                {
                    var req = (context.Controller as AuthorizableBaseController).Request;

                    using (var reader = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
                    {
                        var bodyStr = reader.ReadToEnd();
                        _logger.LogInformation(bodyStr);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            await next();
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
