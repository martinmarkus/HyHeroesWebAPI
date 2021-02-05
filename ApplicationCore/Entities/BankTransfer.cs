using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BankTransfer : BaseEntity
    {
        public int KreditValue { get; set; }

        public string TransferCode { get; set; }

        public int CurrencyValue { get; set; }

        public bool IsActivated { get; set; }

        public string BillingEmail { get; set; }

        public string BillingName { get; set; }

        public string TaxNumber { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public Guid BankTransferBillingAddressId { get; set; }

        public virtual BankTransferBillingAddress BankTransferBillingAddress { get; set; }
    }
}
