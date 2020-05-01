﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class HyCoinResetDTO
    {
        [Required]
        [JsonProperty("UserName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("secretAdminKey")]
        public string SecretAdminKey { get; set; }
    }
}