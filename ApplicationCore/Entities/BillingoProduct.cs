using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoProduct : BaseEntity
    {
        public long BillingoProductId { get; set; }

        public string ProductName { get; set; }

        public string Comment { get; set; }

        public string Currency { get; set; }

        public string Vat { get; set; }

        public string NetUnitPrice { get; set; }

        public string Unit { get; set; }

        public string GeneralLedgerNumber { get; set; }

        public string GeneralLedgerTaxcode { get; set; }

        public string Entitlement { get; set; }

        public Guid BillingoDocumentId { get; set; }

        public virtual BillingoDocument BillingoDocument { get; set; }
    }
}
