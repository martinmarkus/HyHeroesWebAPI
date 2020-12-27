using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string UserName { get; set; }

        //[Required]
        public string Email { get; set; }

        [Required]
        public int Currency { get; set; }

        [Required]
        public int HyCoin { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string PasswordSalt { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        [Required]
        public string LastAuthenticationIp { get; set; }

        [Required]
        public DateTime LastAuthenticationDate { get; set; }

        [Required]
        public bool IsBanned { get; set; } = false;

        public virtual Role Role  { get; set; }
    }
}
