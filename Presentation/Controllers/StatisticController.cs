using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    public class StatisticController : AuthorizableBaseController
    {
        private readonly IStatisticService _statService;

        public StatisticController(
            IStatisticService economicService,
            IUserService userService,
            IAuthorizerService authorizerService)
            : base(userService, authorizerService)
        {
            _statService = economicService ?? throw new ArgumentException(nameof(economicService));
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetMonthlyKreditPurchaseStats/{monthAmount}", Name = "getMonthlyKreditPurchaseStats")]
        [ProducesResponseType(typeof(MonthlyPurchaseStatListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMonthlyPurchaseStats([FromRoute] int monthAmount) =>
             Ok(new MonthlyPurchaseStatListDTO()
             {
                 MonthlyPurchaseStats = await _statService.GetIncomeMonthyAggregationAsync(monthAmount)
             });

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetMonthlyKreditPurchaseStatsByPaymentType/{monthAmount}", Name = "GetMonthlyKreditPurchaseStatsByPaymentType")]
        [ProducesResponseType(typeof(MonthlyPurchaseStatByPaymentTypeListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMonthlyKreditPurchaseStatsByPaymentTypeAsync([FromRoute] int monthAmount) =>
            Ok(await _statService.GetAggregatedStatsByPaymentTypesAsync(monthAmount));

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetOverallIncome", Name = "getOverallIncome")]
        [ProducesResponseType(typeof(OverallIncomeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOverallIncome() =>
            Ok(await _statService.GetOverallIncomeAsync());

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetTopProductStats", Name = "getTopProductStats")]
        [ProducesResponseType(typeof(TopProductStatsListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetTopProductStatsAsync() =>
            Ok(await _statService.GetTopProductStatsAsync());
    }
}
