using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData
{
    public class Invoice : BaseEntity
    {
        public string InvoiceNumber { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public DateTime PaymentDeadlineDate { get; set; }

        public Guid InvoiceIssuerId { get; set; }

        public Guid InvoiceRequesterId { get; set; }

        public virtual InvoiceIssuer InvoiceIssuer { get; set; }

        public virtual InvoiceRequester InvoiceRequester { get; set; }

        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
