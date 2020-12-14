namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class EmailVerifyMailOptions
    {
        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string Subject { get; set; }

        public string BodyWithHtml { get; set; }

        public string VerificationSuccessRedirect { get; set; }

        public string VerificationFailRedirect { get; set; }
    }
}
