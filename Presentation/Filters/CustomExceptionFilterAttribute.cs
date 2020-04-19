using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;

namespace HyHeroesWebAPI.Presentation.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public IWebHostEnvironment Env { get; set; }

        public CustomExceptionFilterAttribute(IWebHostEnvironment env)
        {
            Env = env;
        }

        public override void OnException(ExceptionContext context)
        {
            HttpStatusCode code;
            switch (context.Exception)
            {
                case NotFoundException _:
                    code = HttpStatusCode.NotFound; break;
                case InvalidOperationException _:
                    code = HttpStatusCode.Conflict; break;
                case UnauthorizedAccessException _:
                    code = HttpStatusCode.Unauthorized; break;
                case AlreadyPurchasedException _:
                    code = HttpStatusCode.NotAcceptable; break;
                case BannedUserException _:
                    code = HttpStatusCode.Forbidden; break;
                case NoPermissionException _:
                    code = HttpStatusCode.Forbidden; break;
                case NotEnoughCurrencyException _:
                    code = HttpStatusCode.Forbidden; break;
                case UserAlreadyExistsException _:
                    code = HttpStatusCode.Conflict; break;
                case NullReferenceException _:
                    code = HttpStatusCode.InternalServerError; break;
                default:
                    code = HttpStatusCode.BadRequest; break;
            }

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)code;

            if (!Env.IsProduction())
            {
                context.Result = new JsonResult(new
                {
                    error = new[] { context.Exception.Message },
                    stackTrace = context.Exception.StackTrace
                });
            }
            else
            {
                context.Result = new JsonResult(new
                {
                    error = new[] { context.Exception.Message }
                });
            }
        }
    }
}
