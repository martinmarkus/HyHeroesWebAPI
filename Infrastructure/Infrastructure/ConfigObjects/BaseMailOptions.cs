namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public abstract class BaseMailOptions
    {
        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string Subject { get; set; }

        public string BodyWithHtml { get; set; }
    }
}
