using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalShippingNameDTO
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }
}
