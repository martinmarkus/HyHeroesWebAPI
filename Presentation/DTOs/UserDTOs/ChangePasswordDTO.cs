using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class ChangePasswordDTO
    {
        [Required]
        [JsonProperty("oldPassword")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,20}$")]
        public string OldPassword { get; set; }

        [Required]
        [JsonProperty("newPassword")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,20}$")]
        public string NewPassword {get;set;}
    }
}
