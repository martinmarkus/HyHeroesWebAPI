using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPayeeDTO
    {
        [JsonProperty("email_address")]
        public string Email { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }
    }
}
