using System.Collections.Generic;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public class AppSettings
    {
        public string AuthenticationSecretKey { get; set; }

        public string IPValidatorSecretKey { get; set; }

        public string IntegrationKey { get; set; }

        public string ZipCodesFilePath { get; set; }

        public int EmailVerifyCodeLimitPerHour { get; set; }

        public DiscordSettings DiscordSettings { get; set; }

        public int OnlinePlayerSimulatorInterval { get; set; }

        public int SessionTokenValidityMins { get; set; }

        public string ExternalAuthKey { get; set; }

        public int MinimumKreditGiftAmount { get; set; }

        public JatekFizetesOptions JatekFizetesOptions { get; set; }

        public SzamlazzHuConfig SzamlazzHuConfig { get; set; }

        public SellerData SellerData { get; set; }

        public IList<EDSMSPurchaseType> EDSMSPurchaseTypes { get; set; }

        public PayPalConfig PayPalConfig { get; set; }

        public SmtpHost SmtpHost { get; set; }

        public EmailVerifyMailOptions EmailVerifyMailOptions { get; set; }

        public PasswordResetMailOptions PasswordResetMailOptions { get; set; }

        public IpBlacklistOptions IpBlacklistOptions { get; set; }

        public CustomBarionSettings CustomBarionSettings { get; set; }

        public BarionPurchaseType[] BarionPurchaseTypes { get; set; }

        public BankTransferPurchaseType[] BankTransferPurchaseTypes { get; set; }

        public AcceptedCountry[] AcceptedCountries { get; set; }

        public BankTransferSellerData BankTransferSellerData { get; set; }

        public NotificationMessages NotificationMessages { get; set; }

        public BillingoBillingSettings BillingoBillingSettings { get; set; }
    }
}
