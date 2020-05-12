using HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IEconomicService
    {
        Task<IList<MonthlyPurchaseStatDTO>> GetMonthlyPurchaseStatsAsync();
    }
}
