using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class LoginDTO
    {
        [Required]
        [JsonProperty("emailOrUserName")]
        public string EmailOrUserName { get; set; }

        [Required]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{4,30}$")]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
