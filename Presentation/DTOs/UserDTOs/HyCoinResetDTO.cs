﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class HyCoinResetDTO
    {
        [Required]
        [JsonProperty("UserName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }
    }
}