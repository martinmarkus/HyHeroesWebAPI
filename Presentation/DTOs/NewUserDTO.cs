using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewUserDTO
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{6,20}$")]
        public string Password { get; set; }

        [Required]
        [RegularExpression(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")]
        public string LastAuthenticationIp { get; set; }
    }
}
