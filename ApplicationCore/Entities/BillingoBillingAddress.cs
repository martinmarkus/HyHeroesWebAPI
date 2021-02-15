using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoBillingAddress : BaseEntity
    {
        public string StreetName { get; set; }

        public string StreetType { get; set; }

        public string HouseNrc { get; set; }

        public string Country { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public virtual BillingoClient BillingoClient { get; set; }
    }
}
