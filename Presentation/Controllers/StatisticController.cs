using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    public class StatisticController : AuthorizableBaseController
    {
        private readonly IStatisticService _economicService;

        public StatisticController(
            IStatisticService economicService,
            IUserService userService,
            IAuthorizerService authorizerService)
            : base(userService, authorizerService)
        {
            _economicService = economicService ?? throw new ArgumentException(nameof(economicService));
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetMonthlyKreditPurchaseStats/{monthAmount}", Name = "getMonthlyKreditPurchaseStats")]
        [ProducesResponseType(typeof(IList<MonthlyPurchaseStatDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetMonthlyPurchaseStats([FromRoute] int monthAmount) =>
             Ok(await _economicService.GetIncomeMonthyAggregationAsync(monthAmount));

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetOverallIncome", Name = "getOverallIncome")]
        [ProducesResponseType(typeof(OverallIncomeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOverallIncome() =>
            Ok(await _economicService.GetOverallIncomeAsync());


        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("getPurchasesbyPaymentTypeStat", Name = "getPurchasesbyPaymentTypeStat")]
        [ProducesResponseType(typeof(List<PaymentTypeStatDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> getPurchasesbyPaymentTypeStat() =>
            Ok(await _economicService.GetIncomePaymentTypeAggregationAsync());
    }
}