namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoBillingAddress : BaseEntity
    {
        public string CountryCode { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public virtual BillingoPartner BillingoPartner { get; set; }
    }
}
