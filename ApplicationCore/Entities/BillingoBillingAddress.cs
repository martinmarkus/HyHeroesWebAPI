using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoBillingAddress : BaseEntity
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Zip { get; set; }

        public string Region { get; set; }

        public string Street { get; set; }

        public virtual BillingoClient BillingoClient { get; set; }
    }
}
