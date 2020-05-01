using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewUserDTO
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{6,20}$")]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")]
        [JsonProperty("lastAuthenticationIp")]
        public string LastAuthenticationIp { get; set; }
    }
}
