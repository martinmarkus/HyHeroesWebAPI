namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public class PasswordResetMailOptions : BaseMailOptions
    {
        public string PasswordResetSuccessRedirect { get; set; }

        public string PasswordResetFailRedirect { get; set; }
    }
}
