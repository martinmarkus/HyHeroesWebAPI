﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewUserWithoutEmailDTO
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,30}$")]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
