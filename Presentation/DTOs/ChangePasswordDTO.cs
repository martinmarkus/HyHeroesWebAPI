using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ChangePasswordDTO
    {
        [Required]
        [JsonProperty("newPassword")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,20}$")]
        public string NewPassword {get;set;}
    }
}
