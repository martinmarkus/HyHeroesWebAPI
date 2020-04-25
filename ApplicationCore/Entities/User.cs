using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public decimal Currency { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Guid RoleId { get; set; }

        public string LastAuthenticationIp { get; set; }

        public DateTime LastAuthenticationDate { get; set; }

        public bool IsBanned { get; set; }


        public virtual Role Role  { get; set; }
    }
}
