using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class UserDTO
    {
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("currency")]
        public decimal Currency { get; set; }

        [JsonProperty("registrationDate")]
        public DateTime RegistrationDate { get; set; }

        [JsonProperty("lastAuthenticationIp")]
        public string LastAuthenticationIp { get; set; }

        [JsonProperty("lastAuthenticationDate")]
        public DateTime LastAuthenticationDate { get; set; }

        [JsonProperty("isBanned")]
        public bool IsBanned { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }
}
