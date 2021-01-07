using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class MonthlyPurchaseStatByPaymentTypeDTO
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
