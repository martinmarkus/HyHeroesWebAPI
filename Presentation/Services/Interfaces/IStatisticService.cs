using HyHeroesWebAPI.Presentation.DTOs.ProductDTOs;
using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IStatisticService
    {
        Task<IList<MonthlyPurchaseStatDTO>> GetIncomeMonthyAggregationAsync(int monthAmount = 0);

        Task<OverallIncomeDTO> GetOverallIncomeAsync();

        Task<MonthlyPurchaseStatByPaymentTypeListDTO> GetAggregatedStatsByPaymentTypesAsync(int monthAmount);
        
        Task<TopProductStatsListDTO> GetTopProductStatsAsync();

        Task<PurchasedProductListDTO> GetLastPurchaseStatsAsync(int purchaseCount);
    }
}
