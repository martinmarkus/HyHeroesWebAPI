using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class BanStateDTO
    {
        [Required]
        [JsonProperty("IP")]
        public string IP { get; set; }

        [Required]
        [JsonProperty("isBanned")]
        public bool IsBanned { get; set; }
    }
}
