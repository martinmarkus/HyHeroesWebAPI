using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalShippingDTO
    {
        [JsonProperty("name")]
        public PayPalShippingNameDTO Name { get; set; }
        [JsonProperty("address")]
        public PayPalShippingAddressDTO Address { get; set; }
    }
}
