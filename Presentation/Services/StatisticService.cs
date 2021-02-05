using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;
        private readonly IProductRepository _productRepository;
        
        private readonly IProductMapper _productMapper;

        public StatisticService(
            IPurchasedProductRepository purchasedProductRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IProductRepository productRepository,
            IProductMapper productMapper)
        {
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _productRepository = productRepository ?? throw new ArgumentException(nameof(productRepository));
       
            _productMapper = productMapper ?? throw new ArgumentException(nameof(productMapper));
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
                OverallProductPurchaseCount = purchaseCount
            };
        }

        public async Task<IList<MonthlyPurchaseStatDTO>> GetIncomeMonthyAggregationAsync(int monthAmount = 0)
        {
            var purchases = await _kreditPurchaseRepository.GetAllAsync();

            if (purchases == null || purchases.Count == 0)
            {
                return new List<MonthlyPurchaseStatDTO>();
            }
            var monthlyPurchases = new List<MonthlyPurchaseStatDTO>();
            var alreadyCheckedYearMonths = new List<string>();

            for (int i = 0; i < purchases.Count; i++)
            {
                var purchase = purchases[i];

                var month = purchase.CreationDate.Month.ToString();
                var yearMonth = purchase.CreationDate.Year + "-"
                    + (month.Length == 1
                        ? "0" + month
                        : month);

                if (alreadyCheckedYearMonths.Contains(yearMonth))
                {
                    continue;
                }

                var monthlyPurchaseStat = new MonthlyPurchaseStatDTO()
                {
                    MonthDate = yearMonth,
                    PurchaseCount = 0,
                    MonthlyIncome = 0,
                    MonthlyKreditSpent = 0
                };

                for (int j = 0; j < purchases.Count; j++)
                {
                    var checkedPurchasedProduct = purchases[j];

                    var checkedMonth = checkedPurchasedProduct.CreationDate.Month.ToString();
                    var checkedYearMonth = checkedPurchasedProduct.CreationDate.Year + "-"
                        + (checkedMonth.Length == 1
                            ? "0" + checkedMonth
                            : checkedMonth);

                    if (!alreadyCheckedYearMonths.Contains(checkedYearMonth) &&
                        yearMonth.Equals(checkedYearMonth, StringComparison.OrdinalIgnoreCase))
                    {
                        monthlyPurchaseStat.PurchaseCount++;
                        monthlyPurchaseStat.MonthlyIncome += checkedPurchasedProduct.CurrencyValue;
                        monthlyPurchaseStat.MonthlyKreditSpent += checkedPurchasedProduct.KreditValue;
                    }
                }

                alreadyCheckedYearMonths.Add(yearMonth);
                monthlyPurchases.Add(monthlyPurchaseStat);
            }

            if (monthAmount <= 0 || monthAmount > monthlyPurchases.Count)
            {
                return monthlyPurchases;
            }

            var filteredPurchases = new List<MonthlyPurchaseStatDTO>();
            for (int i = monthlyPurchases.Count - 1; i >= monthlyPurchases.Count - monthAmount; i--)
            {
                filteredPurchases.Add(monthlyPurchases[i]);
            }

            return filteredPurchases;
        }

        public async Task<MonthlyPurchaseStatByPaymentTypeListDTO> GetAggregatedStatsByPaymentTypesAsync(int monthAmount)
        {
            var barionPurchases = await _kreditPurchaseRepository.GetAllByPaymentTypeAsync(PaymentType.Barion);
            var payPalPurchases = await _kreditPurchaseRepository.GetAllByPaymentTypeAsync(PaymentType.PayPal);
            var EDSMSpurchases = await _kreditPurchaseRepository.GetAllByPaymentTypeAsync(PaymentType.EDSMS);
            var bankTransferPurchases = await _kreditPurchaseRepository.GetAllByPaymentTypeAsync(PaymentType.BankTransfer);

            return new MonthlyPurchaseStatByPaymentTypeListDTO()
            {
                MonthlyBarionStats = AggregareMonthly(barionPurchases, monthAmount),
                MonthlyPayPalStats = AggregareMonthly(payPalPurchases, monthAmount),
                MonthlyEDSMSStats = AggregareMonthly(EDSMSpurchases, monthAmount),
                BankTransferStats = AggregareMonthly(bankTransferPurchases, monthAmount),
            };
        }

        private IList<MonthlyPurchaseStatByPaymentTypeDTO> AggregareMonthly(
            IList<KreditPurchase> purchases,
            int monthAmount)
        {
            if (purchases == null || purchases.Count == 0)
            {
                return new List<MonthlyPurchaseStatByPaymentTypeDTO>();
            }
            var monthlyPurchases = new List<MonthlyPurchaseStatByPaymentTypeDTO>();
            var alreadyCheckedYearMonths = new List<string>();

            for (int i = 0; i < purchases.Count; i++)
            {
                var purchase = purchases[i];

                var month = purchase.CreationDate.Month.ToString();
                var yearMonth = purchase.CreationDate.Year + "-"
                    + (month.Length == 1
                        ? "0" + month
                        : month);

                if (alreadyCheckedYearMonths.Contains(yearMonth))
                {
                    continue;
                }

                var monthlyPurchaseStat = new MonthlyPurchaseStatByPaymentTypeDTO()
                {
                    MonthDate = yearMonth,
                    PurchaseCount = 0,
                    MonthlyIncome = 0,
                    KreditValue = 0
                };

                for (int j = 0; j < purchases.Count; j++)
                {
                    var checkedPurchasedProduct = purchases[j];

                    var checkedMonth = checkedPurchasedProduct.CreationDate.Month.ToString();
                    var checkedYearMonth = checkedPurchasedProduct.CreationDate.Year + "-"
                        + (checkedMonth.Length == 1
                            ? "0" + checkedMonth
                            : checkedMonth);

                    if (!alreadyCheckedYearMonths.Contains(checkedYearMonth) &&
                        yearMonth.Equals(checkedYearMonth, StringComparison.OrdinalIgnoreCase))
                    {
                        monthlyPurchaseStat.PurchaseCount++;
                        monthlyPurchaseStat.MonthlyIncome += checkedPurchasedProduct.CurrencyValue;
                        monthlyPurchaseStat.KreditValue += checkedPurchasedProduct.KreditValue;
                    }
                }

                alreadyCheckedYearMonths.Add(yearMonth);
                monthlyPurchases.Add(monthlyPurchaseStat);
            }

            if (monthAmount <= 0 || monthAmount > monthlyPurchases.Count)
            {
                return monthlyPurchases;
            }

            var filteredPurchases = new List<MonthlyPurchaseStatByPaymentTypeDTO>();
            for (int i = monthlyPurchases.Count - 1; i >= monthlyPurchases.Count - monthAmount; i--)
            {
                filteredPurchases.Add(monthlyPurchases[i]);
            }

            return filteredPurchases;
        }

        public async Task<TopProductStatsListDTO> GetTopProductStatsAsync()
        {
            var topProducts = await _productRepository.GetTopProductStatsAsync();

            var topProductListDTO = new TopProductStatsListDTO();

            foreach (var product in topProducts)
            {
                topProductListDTO.TopProductStatsDTOs.Add(new TopProductStatsDTO()
                {
                    ProductName = product.Name,
                    PurchaseCount = product.PurchasedProducts.Count
                });
            }

            return topProductListDTO;
        }

        public async Task<PurchasedProductListDTO> GetLastPurchaseStatsAsync(int purchaseCount) =>
            _productMapper.MapAllToPurchasedProductListDTO(
                await _purchasedProductRepository.GetLastPurchasesAsync(purchaseCount));
    }
}
