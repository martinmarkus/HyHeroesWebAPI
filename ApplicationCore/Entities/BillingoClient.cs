using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoClient : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid BillingoBillingAddressId { get; set; }

        public virtual User User { get; set; }

        public virtual BillingoBillingAddress BillingoBillingAddress { get; set; }
    }
}
