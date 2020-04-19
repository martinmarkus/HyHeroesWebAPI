using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData
{
    public class InvoiceRequester : BaseEntity
    {
        public string Name { get; set; }

        public string TaxNumber { get; set; } // kotelezo 2020 07 hotol

        public Guid AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}
