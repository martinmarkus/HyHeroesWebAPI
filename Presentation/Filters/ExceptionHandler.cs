using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Filters
{
    public class ExceptionHandler : ExceptionFilterAttribute, IExceptionFilter
    {
        private readonly IUserService _userService;
        private readonly ICustomAntiforgeryService _customAntiforgeryService;
        public ExceptionHandler(
            IUserService userService,
            ICustomAntiforgeryService customAntiforgeryService)
        {
            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _customAntiforgeryService = customAntiforgeryService ?? throw new ArgumentException(nameof(customAntiforgeryService));
        }

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
                    code = HttpStatusCode.Forbidden; break;
                case UserAlreadyExistsException _:
                    code = HttpStatusCode.UnprocessableEntity; break;
                case EmailAlreadyExistsException _:
                    code = HttpStatusCode.UnprocessableEntity; break;
                case WrongPasswordException _:
                    code = HttpStatusCode.UnavailableForLegalReasons; break;
                case DbUpdateException _:
                    code = HttpStatusCode.Conflict; break;
                case NullReferenceException _:
                    code = HttpStatusCode.InternalServerError; break;
                case BillingException _:
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
