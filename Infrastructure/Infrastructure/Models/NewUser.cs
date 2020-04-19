namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Models
{
    public class NewUser
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public string LastAuthenticationIp { get; set; }

    }
}
