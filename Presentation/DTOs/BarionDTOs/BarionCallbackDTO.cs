using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.BarionDTOs
{
    public class BarionCallbackDTO
    {
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }
    }
}
