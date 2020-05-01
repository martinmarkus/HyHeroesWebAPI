using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class AuthenticatedUserDTO
    {
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        [EmailAddress]
        public string Email { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("userId")] 
        public string Id { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("accessToken")]
        public string Token { get; set; }

        [JsonProperty("isBanned")]
        public string IsBanned { get; set; }

        [JsonProperty("expiresIn")]
        public string ExpiresIn { get; set; }
    }
}
