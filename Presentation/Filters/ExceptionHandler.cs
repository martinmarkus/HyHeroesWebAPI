using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ExceptionHandler : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(ExceptionContext context)
        {
            //switch (context.Exception)
            //{
            //    case NotFoundException _:
            //        context.Result = new NotFoundResult(); break;
            //    case InvalidOperationException _:
            //        context.Result = new ConflictResult(); break;
            //    case UnauthorizedAccessException _:
            //        context.Result = new UnauthorizedResult(); break;
            //    case AlreadyPurchasedException _:
            //        context.Result = new BadRequestResult(); break;
            //    case BannedUserException _:
            //        context.Result = new ForbidResult(); break;
            //    case NoPermissionException _:
            //        context.Result = new ForbidResult(); break;
            //    case NotEnoughCurrencyException _:
            //        context.Result = new ForbidResult(); break;
            //    case UserAlreadyExistsException _:
            //        context.Result = new ConflictResult(); break;
            //    case UserAlreadyBannedException _:
            //        context.Result = new BadRequestResult(); break;
            //    case NotImplementedException _:
            //        context.Result = new NotFoundResult(); break;
            //    default:
            //        context.Result = new BadRequestResult(); break;
            //}

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

            context.Result = new JsonResult(new
            {
                error = new[] { context.Exception.Message },
                stackTrace = context.Exception.StackTrace
            });
        }
    }
}
