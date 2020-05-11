using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class EconomicService : IEconomicService
    {
        private readonly IPurchasedProductRepository _purchasedProductRepository;

        public EconomicService(IPurchasedProductRepository purchasedProductRepository)
        {
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
        }

        public async Task<IList<MonthlyPurchaseStat>> GetMonthlyPurchaseStatsAsync()
        {
            var purchases = await _purchasedProductRepository.GetAllAsync();

            string yearAndMonth = string.Empty;
            foreach (var purchase in purchases)
            {

            }

            var monthlyAggregatedPurchases = new List<MonthlyPurchaseStat>();
            throw new NotImplementedException();
        }
    }
}
