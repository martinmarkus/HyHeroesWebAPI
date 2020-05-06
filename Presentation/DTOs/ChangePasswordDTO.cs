using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ChangePasswordDTO
    {
        [Required]
        [JsonProperty("oldPassword")]
        // TODO: uncomment
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,20}$")]
        public string OldPassword { get; set; }
        [Required]
        [JsonProperty("newPassword")]
        // TODO: uncomment
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,20}$")]
        public string NewPassword {get;set;}
    }
}
