using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class VerifyPasswordDTO
    {
        [Required]
        [JsonProperty("password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,30}$")]
        public string Password { get; set; }
    }
}
