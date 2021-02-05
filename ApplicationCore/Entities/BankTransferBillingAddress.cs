using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BankTransferBillingAddress : BaseEntity
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string Region { get; set; }

        public string Street { get; set; }

        public Guid BankTransferId { get; set; }

        public virtual BankTransfer BankTransfer { get; set; }
    }
}
