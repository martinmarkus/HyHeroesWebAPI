using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class UpdateUserDTO
    {
        [Required]
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [Required]
        [JsonProperty("hyCoin")]
        public string HyCoin { get; set; }

        [Required]
        [JsonProperty("isBanned")]
        public string IsBanned { get; set; }

        [Required]
        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }
}
