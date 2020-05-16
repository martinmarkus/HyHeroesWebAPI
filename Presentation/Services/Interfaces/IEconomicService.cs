﻿using HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IEconomicService
    {
        Task<IList<MonthlyPurchaseStatDTO>> GetMonthlyPurchaseStatsAsync();

        Task<IncomeDTO> GetOverallIncomeAsync();

        Task<IncomeDTO> GetIncomeOfAcutalDayAsync();

        Task<IncomeDTO> GetIncomeOfActualWeekAsync();
    }
}
