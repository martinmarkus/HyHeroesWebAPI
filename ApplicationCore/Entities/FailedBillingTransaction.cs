using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class FailedBillingTransaction : BaseEntity
    {
        public DateTime FailDate { get; set; }

        [Required]
        public int KreditAmount { get; set; }

        public string ErrorMessage{ get; set; }

        [Required]
        public Guid BillingTransactionId { get; set; }

        public virtual BillingTransaction BillingTransaction { get; set; }
    }
}
