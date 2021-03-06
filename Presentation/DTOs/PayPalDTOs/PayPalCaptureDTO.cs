using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalCaptureDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("event_version")]
        public string EventVersion { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }

        [JsonProperty("resource_version")]
        public string ResourceVersion { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("resource")]
        public PayPalResourceDTO PayPalResource { get; set; }

        [JsonProperty("links")]
        public List<PayPalLinkDTO> PayPalLinks { get; set; }
    }
}
