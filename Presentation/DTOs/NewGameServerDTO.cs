using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewGameServerDTO
    {
        [Required]
        [JsonProperty("serverName")]
        public string ServerName{ get; set; }
    }
}
