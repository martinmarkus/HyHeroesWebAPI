namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class SmtpHost
    {
        public string Host { get; set; }

        public string Port { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EnableSsl { get; set; }
    }
}
