﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class UserDTO
    {
        [Required]
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [JsonProperty("currency")]
        public decimal Currency { get; set; }

        [Required]
        [JsonProperty("registrationDate")]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [JsonProperty("lastAuthenticationIp")]
        public string LastAuthenticationIp { get; set; }

        [Required]
        [JsonProperty("lastAuthenticationDate")]
        public DateTime LastAuthenticationDate { get; set; }

        [Required]
        [JsonProperty("isBanned")]
        public bool IsBanned { get; set; }

        [Required]
        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }
}
