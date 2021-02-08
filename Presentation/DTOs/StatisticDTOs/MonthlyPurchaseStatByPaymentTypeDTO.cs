using HyHeroesWebAPI.Presentation.DTOs.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class MonthlyPurchaseStatByPaymentTypeDTO : IComparablePurchaseStatDTO
    {
        [JsonProperty("monthDate")]
        public string MonthDate { get; set; }

        [JsonProperty("monthlyIncome")]
        public int MonthlyIncome { get; set; }

        [JsonProperty("purchaseCount")]
        public int PurchaseCount { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }
    }
}
