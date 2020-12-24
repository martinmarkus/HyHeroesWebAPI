using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ResetForgottenPasswordDTO
    {
        [Required]
        [JsonProperty("resetCode")]
        public Guid ResetCode { get; set; }

        [Required]
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }
}
