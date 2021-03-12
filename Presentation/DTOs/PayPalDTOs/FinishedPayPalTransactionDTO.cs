using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class FinishedPayPalTransactionDTO
    {
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("kreditAmount")]
        public int KreditAmount { get; set; }
    }
}
