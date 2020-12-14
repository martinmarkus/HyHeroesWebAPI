using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class VerifyEmailDTO
    {
        [Required]
        [JsonProperty("emailToVerify")]
        [EmailAddress]
        public string EmailToVerify { get; set; }
    }
}
