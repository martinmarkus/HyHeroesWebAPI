namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class AppSettings
    {
        public string SecretKey { get; set; }
        public string SecretAdminKey { get; set; }

        public SellerData SellerData { get; set; }
    }
}
