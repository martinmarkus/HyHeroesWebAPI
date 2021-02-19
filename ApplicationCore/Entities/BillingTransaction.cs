using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingTransaction : BaseEntity
    {
        public string UserName { get; set; }
        public DateTime BillingDate { get; set; } = DateTime.Now;

        public string ProductName { get; set; }
        public bool IsBilled { get; set; } = false;

        public string CountryCode { get; set; }
        public string Taxnumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
