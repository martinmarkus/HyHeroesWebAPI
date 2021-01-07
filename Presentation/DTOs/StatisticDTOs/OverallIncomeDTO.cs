using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class OverallIncomeDTO
    {
        [JsonProperty("overallIncome")]
        public int OverallIncome { get; set; }

        [JsonProperty("overallKreditIncome")]
        public int OverallKreditIncome { get; set; }

        [JsonProperty("overallKreditPurchaseCount")]
        public int OverallKreditPurchaseCount { get; set; }

        [JsonProperty("overallProductPurchaseCount")]
        public int OverallProductPurchaseCount { get; set; }
    }
}
