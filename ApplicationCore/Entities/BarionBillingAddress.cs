using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BarionBillingAddress : BaseEntity
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string Region { get; set; }

        public string Street { get; set; }

        public string Street2 { get; set; }

        public string Street3 { get; set; }

        public Guid BarionTransactionId { get; set; }

        public virtual BarionTransaction BarionTransaction { get; set; }
    }
}
