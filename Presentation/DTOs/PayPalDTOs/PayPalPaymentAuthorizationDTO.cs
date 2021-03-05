using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPaymentAuthorizationDTO
    {
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
        [JsonProperty("orthography")]
        public string Orthography { get; set; }
    }
}
