using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class LatestNewsDTO
    {
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [Required]
        [JsonProperty("formattedValue")]
        public string FormattedValue { get; set; }
    }
}
