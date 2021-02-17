using HyHeroesWebAPI.ApplicationCore.Entities;

namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class BillingoBillingSettings
    {
        public string BillingoApiRoute { get; set; }

        public string BillingoApiKey { get; set; }

        public string Vat { get; set; }

        public string Unit { get; set; }

        public string Entitlement { get; set; }

        public string Language { get; set; }

        public string Currency { get; set; }

        public string Type { get; set; }

        public int ConversionRate { get; set; }

        public BillingoBankAccountConfig BillingoBankAccount { get; set; }
    }
}
