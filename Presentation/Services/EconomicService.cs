using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs;
using HyHeroesWebAPI.Presentation.Mapper;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class EconomicService : IEconomicService
    {
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;

        public EconomicService(
            IPurchasedProductRepository purchasedProductRepository,
            IKreditPurchaseRepository kreditPurchaseRepository)
        {
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
        }

        public async Task<OverallIncomeDTO> GetOverallIncomeAsync()
        {
            var kreditPurchases = await _kreditPurchaseRepository.GetAllAsync();
            var incomeSum = 0;
            var kreditSum = 0;
            foreach (var kreditPurchase in kreditPurchases)
            {
                incomeSum += kreditPurchase.CurrencyValue;
                kreditSum += kreditPurchase.KreditValue;
            }

            var purchaseCount = await _purchasedProductRepository.GetCountOfOverallPurchasesAsync();

            return new OverallIncomeDTO()
            {
                OverallKreditIncome = kreditSum,
                OverallIncome = incomeSum,
                OverallKreditPurchaseCount = kreditPurchases.Count,
                OverallPurchaseCount = purchaseCount
            };
        }

        public async Task<IList<MonthlyPurchaseStatDTO>> GetIncomeMonthyAggregationAsync()
        {
            var purchases = await _kreditPurchaseRepository.GetAllAsync();
            var monthlyAggregatedPurchases = new List<MonthlyPurchaseStatDTO>();
            var alreadyCheckedYearMonths = new List<string>();

            for (int i = 0; i < purchases.Count; i++)
            {
                var purchase = purchases[i];
                var yearMonth = purchase.CreationDate.Year + "-" + purchase.CreationDate.Month;

                if (alreadyCheckedYearMonths.Contains(yearMonth))
                {
                    continue;
                }

                var monthlyPurchaseStat = new MonthlyPurchaseStatDTO()
                {
                    MonthDate = Convert.ToDateTime(yearMonth),
                    PurchaseCount = 0,
                    MonthlyIncome = 0,
                    MonthlyKreditSpent = 0
                };

                for (int j = 0; j < purchases.Count; j++)
                {
                    var checkedPurchasedProduct = purchases[j];
                    var checkedYearMonth = checkedPurchasedProduct.CreationDate.Year + "-" + checkedPurchasedProduct.CreationDate.Month;

                    if (!alreadyCheckedYearMonths.Contains(checkedYearMonth) &&
                        yearMonth.Equals(checkedYearMonth, StringComparison.OrdinalIgnoreCase))
                    {
                        monthlyPurchaseStat.PurchaseCount++;
                        monthlyPurchaseStat.MonthlyIncome += checkedPurchasedProduct.CurrencyValue;
                        monthlyPurchaseStat.MonthlyKreditSpent += checkedPurchasedProduct.KreditValue;
                    }
                }

                alreadyCheckedYearMonths.Add(yearMonth);
                monthlyAggregatedPurchases.Add(monthlyPurchaseStat);
            }

            return monthlyAggregatedPurchases;
        }

        public async Task<IList<PaymentTypeStatDTO>> GetIncomePaymentTypeAggregationAsync()
        {
            var EDSMSPurchases = await _kreditPurchaseRepository.GetAllEDSMSKreditPurchasesAsync();
            var barionPurchases = await _kreditPurchaseRepository.GetAllBarionPurchasesesAsync();
            var payPalPurchases = await _kreditPurchaseRepository.GetAllPayPalPurchasesAsync();

            var EDSMSStat = GetPaymentTypeStats(EDSMSPurchases, PaymentType.EDSMS);
            var barionStat = GetPaymentTypeStats(barionPurchases, PaymentType.Barion);
            var payPalStat = GetPaymentTypeStats(payPalPurchases, PaymentType.PayPal);

            return new List<PaymentTypeStatDTO>()
            {
                EDSMSStat,
                barionStat,
                payPalStat
            };
        }

        private PaymentTypeStatDTO GetPaymentTypeStats(IList<KreditPurchase> purchases, PaymentType paymentType)
        {
            var stat = new PaymentTypeStatDTO()
            {
                PurchaseCount = purchases.Count,
                PurchaseCurrencySum = 0,
                PurchaseKreditSum = 0,
                PaymentType = paymentType
            };

            foreach (var purchase in purchases)
            {
                stat.PurchaseCurrencySum += purchase.CurrencyValue;
                stat.PurchaseKreditSum += purchase.KreditValue;
            }

            return stat;
        }
    }
}
