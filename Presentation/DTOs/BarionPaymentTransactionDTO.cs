namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionPaymentTransactionDTO
    {
        public string UserName { get; set; }

        public string PayeeEmail { get; set; }

        public string Locale { get; set; }

        public string CurrencyType { get; set; }

        public BarionBillingAddressDTO BarionBillingAddressDTO { get; set; }

        public BarionTransactionDTO BarionTransactionDTO { get; set; }

        public double KreditAmount { get; set; }

        public string Comment { get; set; }

        public string Quantity { get; set; }
    }
}
