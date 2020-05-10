using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class KreditTransactionDTO
    {
        [Required]
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [Required]
        [JsonProperty("secretAdminKey")]
        public string SecretAdminKey { get; set; }
    }
}
