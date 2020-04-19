using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData
{
    public class InvoiceIssuer : BaseEntity
    {
        public string Name { get; set; }

        public string TaxNumber { get; set; }

        #nullable enable
        public string? EuTaxNumber { get; set; }

        #nullable disable

        public string BankAccountNumber { get; set; }

        public Guid AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
