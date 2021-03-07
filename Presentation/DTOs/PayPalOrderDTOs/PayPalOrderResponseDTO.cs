using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalOrderResponseDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
