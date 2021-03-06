using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalCaptureStatusDTO
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
