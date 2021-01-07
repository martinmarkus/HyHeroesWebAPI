using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class TopProductStatsDTO
    {
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("purchaseCount")]
        public int PurchaseCount { get; set; }
    }
}
