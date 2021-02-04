using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ExceptionHandler : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(ExceptionContext context)
        {
            HttpStatusCode code;
            switch (context.Exception)
            {
                case NotFoundException _:
                    code = HttpStatusCode.NotFound; break;
                case UnauthorizedAccessException _:
                    code = HttpStatusCode.Unauthorized; break;
                case AlreadyPurchasedException _:
                    code = HttpStatusCode.NotAcceptable; break;
                case BannedUserException _:
                    code = HttpStatusCode.Forbidden; break;
                case NoPermissionException _:
                    code = HttpStatusCode.Forbidden; break;
                case NotEnoughCurrencyException _:
                    code = HttpStatusCode.NotAcceptable; break;
                case InvalidKreditAmountException _:
                    code = HttpStatusCode.NotExtended; break;
                case SelfKreditGiftingxception _:
                    code = HttpStatusCode.UnprocessableEntity; break;
                case UserAlreadyExistsException _:
                    code = HttpStatusCode.UnprocessableEntity; break;
                case EmailAlreadyExistsException _:
                    code = HttpStatusCode.UnprocessableEntity; break;
                case WrongPasswordException _:
                    code = HttpStatusCode.UnavailableForLegalReasons; break;
                case DbUpdateException _:
                    code = HttpStatusCode.Conflict; break;
                case JatekfizetesCooldownException _:
                    code = HttpStatusCode.BadGateway; break;
                case NullReferenceException _:
                    code = HttpStatusCode.InternalServerError; break;
                case 
                BillingException _:
                    code = HttpStatusCode.InternalServerError; break;
                case MissingUserEmailException _:
                    code = HttpStatusCode.NotFound; break;
                case MissingBarionPayeeException _:
                    code = HttpStatusCode.NotFound; break;
                default:
                    code = HttpStatusCode.BadRequest; break;
            }

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)code;

            context.Result = new JsonResult(new
            {
                status = code,
                error = new[] { context.Exception.Message },
                stackTrace = context.Exception.StackTrace
            });
        }
    }
}
