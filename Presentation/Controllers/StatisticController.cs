using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [ValidateIP]
    [ValidateCustomAntiforgery]
    public class StatisticController : AuthorizableBaseController
    {
        private readonly IStatisticService _statService;

        public StatisticController(
            IStatisticService economicService,
            IUserService userService,
            IAuthorizerService authorizerService,
            IIPValidatorService IPValidatorService,
            ICustomAntiforgeryService customAntiforgeryService,
            IOptions<AppSettings> appSettings)
            : base(userService, authorizerService, IPValidatorService, customAntiforgeryService, appSettings)
        {
            _statService = economicService ?? throw new ArgumentException(nameof(economicService));
        }

        [RequiredRole("Admin")]
        [HttpGet("GetMonthlyKreditPurchaseStats/{monthAmount}", Name = "getMonthlyKreditPurchaseStats")]
        [ProducesResponseType(typeof(MonthlyPurchaseStatListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMonthlyPurchaseStats(
            [FromRoute][Required] int monthAmount) =>
             Ok(new MonthlyPurchaseStatListDTO()
             {
                 MonthlyPurchaseStats = await _statService.GetIncomeMonthyAggregationAsync(monthAmount)
             });

        [RequiredRole("Admin")]
        [HttpGet("GetMonthlyKreditPurchaseStatsByPaymentType/{monthAmount}", Name = "GetMonthlyKreditPurchaseStatsByPaymentType")]
        [ProducesResponseType(typeof(MonthlyPurchaseStatByPaymentTypeListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMonthlyKreditPurchaseStatsByPaymentTypeAsync(
            [FromRoute][Required] int monthAmount) =>
            Ok(await _statService.GetAggregatedStatsByPaymentTypesAsync(monthAmount));

        [RequiredRole("Admin")]
        [HttpGet("GetTopProductStats", Name = "getTopProductStats")]
        [ProducesResponseType(typeof(TopProductStatsListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetTopProductStatsAsync() =>
            Ok(await _statService.GetTopProductStatsAsync());

        [RequiredRole("Admin")]
        [HttpGet("GetLastPurchaseStats", Name = "GetLastPurchaseStats")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetLastPurchaseStatsAsync(
            [FromRoute][Required] int purchaseCount) =>
            Ok(await _statService.GetLastPurchaseStatsAsync(purchaseCount));

        [RequiredRole("Admin")]
        [HttpGet("GetOverallIncome", Name = "getOverallIncome")]
        [ProducesResponseType(typeof(OverallIncomeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOverallIncome() =>
            Ok(await _statService.GetOverallIncomeAsync());
    }
}
