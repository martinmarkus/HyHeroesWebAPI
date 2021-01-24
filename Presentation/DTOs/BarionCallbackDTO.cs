using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionCallbackDTO
    {
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }
    }
}
