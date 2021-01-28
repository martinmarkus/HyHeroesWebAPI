using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class SendKreditGiftDTO
    {
        [Required]
        [JsonProperty("kreditGiftAmount")]
        public int KreditGiftAmount { get; set; }

        [Required]
        [JsonProperty("receiverUserNameOrEmail")]
        public string ReceiverUserNameOrEmail { get; set; }

        [Required]
        [JsonProperty("confirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
