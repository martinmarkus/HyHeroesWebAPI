namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class EmailVerifyMailOptions : BaseMailOptions
    {
        public string VerificationSuccessRedirect { get; set; }

        public string VerificationFailRedirect { get; set; }
    }
}
