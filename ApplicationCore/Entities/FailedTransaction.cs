using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class FailedTransaction : BaseEntity
    {
        public DateTime FailDate { get; set; }

        [Required]
        public Guid PurchasedProductId { get; set; }

        [Required]
        public Guid BillingTransactionId { get; set; }

        public virtual PurchasedProduct PurchasedProduct { get; set; }

        public virtual BillingTransaction BillingTransaction { get; set; }
    }
}
