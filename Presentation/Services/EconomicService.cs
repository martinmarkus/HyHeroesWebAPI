using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
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

        public async Task<IList<MonthlyPurchaseStatDTO>> GetMonthlyPurchaseStatsAsync()
        {
            var purchasedProducts = await _purchasedProductRepository.GetAllAsync();
            var monthlyAggregatedPurchases = new List<MonthlyPurchaseStatDTO>();

            var alreadyCheckedYearMonths = new List<string>();

            for (int i = 0; i < purchasedProducts.Count; i++)
            {
                var purchasedProduct = purchasedProducts[i];
                var yearMonth = purchasedProduct.PurchaseDate.Year + "-" + purchasedProduct.PurchaseDate.Month;

                if (alreadyCheckedYearMonths.Contains(yearMonth))
                {
                    continue;
                }

                var monthlyPurchaseStat = new MonthlyPurchaseStatDTO()
                {
                    MonthDate = Convert.ToDateTime(yearMonth),
                    PurchaseCount = 0,
                    MonthlyIncome = 0
                };

                for (int j = 0; j < purchasedProducts.Count; j++)
                {
                    var checkedPurchasedProduct = purchasedProducts[j];
                    var checkedYearMonth = checkedPurchasedProduct.PurchaseDate.Year + "-" + checkedPurchasedProduct.PurchaseDate.Month;
                    
                    if (!alreadyCheckedYearMonths.Contains(checkedYearMonth) && 
                        yearMonth.Equals(checkedYearMonth, StringComparison.OrdinalIgnoreCase))
                    {
                        monthlyPurchaseStat.PurchaseCount++;

                        if (checkedPurchasedProduct.IsPermanent)
                        {
                            monthlyPurchaseStat.MonthlyIncome += Convert.ToInt32(
                                checkedPurchasedProduct.Product.PermanentPrice * checkedPurchasedProduct.ActualValueOfOneKredit);
                        } 
                        else
                        {
                            monthlyPurchaseStat.MonthlyIncome += Convert.ToInt32(
                                checkedPurchasedProduct.Product.PricePerMonth * checkedPurchasedProduct.ValidityPeriodInMonths
                                * checkedPurchasedProduct.ActualValueOfOneKredit);
                        }
                    }
                }

                alreadyCheckedYearMonths.Add(yearMonth);
                monthlyAggregatedPurchases.Add(monthlyPurchaseStat);
            }

            return monthlyAggregatedPurchases;
        }
    }
}
