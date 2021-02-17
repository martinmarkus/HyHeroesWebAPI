using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoPartner : BaseEntity
    {
        public long BillingoPartnerId { get; set; }

        public string PartnerName { get; set; }

        public string Email { get; set; }

        public string Taxcode { get; set; }

        public string Iban { get; set; }

        public string Swift { get; set; }

        public string AccountNumber { get; set; }

        public string Phone { get; set; }

        public string GeneralLedgerNumber { get; set; }

        public string TaxType { get; set; }

        public Guid BillingoBillingAddressId { get; set; }

        public virtual BillingoBillingAddress BillingoBillingAddress { get; set; }
    }
}
