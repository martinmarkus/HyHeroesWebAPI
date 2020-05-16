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
        public async Task<IActionResult> GetMonthlyPurchaseStats() =>
             Ok(await _economicService.GetMonthlyPurchaseStatsAsync());

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetOverallIncome", Name = "getOverallIncome")]
        [ProducesResponseType(typeof(IncomeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOverallIncome() =>
            Ok(await _economicService.GetOverallIncomeAsync());

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetIncomeOfAcutalDay", Name = "getIncomeOfAcutalDay")]
        [ProducesResponseType(typeof(IncomeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetIncomeOfAcutalDay() =>
           Ok(await _economicService.GetIncomeOfAcutalDayAsync());

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetIncomeOfActualWeek", Name = "getIncomeOfActualWeek")]
        [ProducesResponseType(typeof(IncomeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetIncomeOfActualWeek() =>
            Ok(await _economicService.GetIncomeOfActualWeekAsync());
    }
}