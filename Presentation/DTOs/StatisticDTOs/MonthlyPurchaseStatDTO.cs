using HyHeroesWebAPI.Presentation.DTOs.Interfaces;
using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class MonthlyPurchaseStatDTO : IComparablePurchaseStatDTO
    {
        [JsonProperty("monthDate")]
        public string MonthDate { get; set; }

        [JsonProperty("purchaseCount")]
        public int PurchaseCount { get; set; }

        [JsonProperty("monthlyIncome")]
        public int MonthlyIncome { get; set; }

        [JsonProperty("monthlyKreditSpent")]
        public int MonthlyKreditSpent { get; set; }
    }
}
