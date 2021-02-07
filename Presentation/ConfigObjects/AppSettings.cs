using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class AppSettings
    {
        public string SecretKey { get; set; }

        public string IPValidatorSecretKey { get; set; }

        public string IntegrationKey { get; set; }

        public string ZipCodesFilePath { get; set; }

        public int MinimumKreditGiftAmount { get; set; }

        public JatekFizetesOptions JatekFizetesOptions { get; set; }

        public SellerData SellerData { get; set; }

        public IList<EDSMSPurchaseTypeDTO> EDSMSPurchaseTypes { get; set; }

        public PayPalConfig PayPalConfig { get; set; }

        public SmtpHost SmtpHost { get; set; }

        public EmailVerifyMailOptions EmailVerifyMailOptions { get; set; }

        public PasswordResetMailOptions PasswordResetMailOptions { get; set; }

        public IpBlacklistOptions IpBlacklistOptions { get; set; }

        public CustomBarionSettings CustomBarionSettings { get; set; }

        public BarionPurchaseType[] BarionPurchaseTypes { get; set; }

        public BankTransferPurchaseType[] BankTransferPurchaseTypes { get; set; }

        public BankTransferSellerData BankTransferSellerData { get; set; }
    }
}
