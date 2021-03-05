using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPayerDTO
    {
        [JsonProperty("name")]
        public PayPalPayerNameDTO Name { get; set; }
        [JsonProperty("email_address")]
        public string Email { get; set; }
        [JsonProperty("payer_id")]
        public string PayerId { get; set; }
        [JsonProperty("address")]
        public PayPalShippingAddressDTO Address { get; set; }
    }
}
