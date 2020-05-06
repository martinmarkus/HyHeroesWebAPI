namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Models
{
    public class LoginUser
    {
        public string EmailOrUserName { get; set; }

        public string Password { get; set; }

        public string LastAuthenticationIp { get; set; }

        public string LastAuthenticationDate { get; set; }
    }
}
