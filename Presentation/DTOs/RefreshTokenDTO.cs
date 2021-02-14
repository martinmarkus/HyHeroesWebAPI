using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class RefreshTokenDTO
    {
        [Required]
        [JsonProperty("tokenValue")]
        public string TokenValue { get; set; }

        [Required]
        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}
