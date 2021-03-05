using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalOrderResponseDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        //[JsonProperty("status")]
        //public string PayPalStatus { get; set; }

        //[JsonProperty("links")]
        //public List<PayPalLinkDTO> Links { get; set; }
    }
}
