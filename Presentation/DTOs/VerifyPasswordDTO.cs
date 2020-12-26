using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class VerifyPasswordDTO
    {
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
