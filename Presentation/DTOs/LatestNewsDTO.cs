using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class LatestNewsDTO
    {
        [Required]
        [JsonProperty("formettedValue")]
        public string FormattedValue { get; set; }
    }
}
