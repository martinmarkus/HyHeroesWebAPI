using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPurchaseDetailsDTO
    {
        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }
    }
}
