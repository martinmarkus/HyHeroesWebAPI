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
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,30}$")]
        public string NewPassword { get; set; }
    }
}
