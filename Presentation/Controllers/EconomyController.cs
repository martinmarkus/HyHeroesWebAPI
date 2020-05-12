using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    public class EconomyController : AuthorizableBaseController
    {
        private readonly IEconomicService _economicService;

        public EconomyController(
            IEconomicService economicService,
            IUserService userService,
            IAuthorizerService authorizerService)
            : base(userService, authorizerService)
        {
            _economicService = economicService ?? throw new ArgumentException(nameof(economicService));
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetMonthlyPurchaseStats", Name = "getMonthlyPurchaseStats")]
        [ProducesResponseType(typeof(IList<MonthlyPurchaseStatDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMonthlyPurchaseStats()
        {
            return Ok(await _economicService.GetMonthlyPurchaseStatsAsync());
        }
    }
}