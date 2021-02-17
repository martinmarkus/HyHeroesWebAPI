using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoDocument : BaseEntity
    {
        public long BillingoDocumentId { get; set; }

        public string VendorId { get; set; }
        public long PartnerId { get; set; }
        public long BlockId { get; set; }
        public long BankAccountId { get; set; }
        public string Type { get; set; }
        public DateTime FulfillmentDate { get; set; }
        public DateTime DueDate { get; set; }

        // INFO: Payment method (payment_method field)
        public PaymentType PaymentType { get; set; }
        public int ConversionRate { get; set; }
        public bool Electronic { get; set; }
        public bool Paid { get; set; } 
        public string Comment { get; set; }

        public Guid BillingoPartnerId { get; set; }
        public virtual BillingoPartner BillingoPartner { get; set; }

        public virtual IList<BillingoProduct> BillingoProducts { get; set; }

        public Guid BillingoDocumentSettingsId { get; set; }
        public virtual BillingoDocumentSettings BillingoDocumentSettings { get; set; }
    }
}
