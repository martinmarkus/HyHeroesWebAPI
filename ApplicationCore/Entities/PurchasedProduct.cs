using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PurchasedProduct : BaseEntity
    {

        [Required]
        public DateTime LastPurchaseDate { get; set; }

        [Required]
        public bool IsPermanent { get; set; }

        [Required]
        public bool IsRepeatable { get; set; }

        //[Required]
        //public bool IsVerified { get; set; }

        //[Required]
        //public bool IsExpirationVerified { get; set; }

        [Required]
        public bool IsOverwrittenByOtherRank { get; set; }

        [Required]
        public int ValidityPeriodInMonths { get; set; }

        [Required]
        public int KreditSpentOn { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        //[Required]
        //public Guid ServerActivationId { get; set; }

        public virtual User User { get; set; }

        public virtual Product Product { get; set; }

        public virtual IList<PurchaseState> PurchaseStates { get; set; }

        //public ServerActivation ServerActivation { get; set; }
    }
}
