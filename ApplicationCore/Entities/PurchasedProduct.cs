using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PurchasedProduct : BaseEntity
    {

        [Required]
        public DateTime PurchaseDate { get; set; }


        [Required]
        public bool IsPermanent { get; set; }


        [Required]
        public bool IsRepeatable { get; set; }


        [Required]
        public bool IsVerified { get; set; }


        [Required]
        public bool IsExpirationVerified { get; set; }

        [Required]
        public bool IsOverwrittenByOtherRank { get; set; }


        [Required]
        public int ValidityPeriodInMonths { get; set; }


        [Required]
        public decimal ActualValueOfOneKredit { get; set; }

        [Required]
        public Guid UserId { get; set; }


        [Required]
        public Guid ProductId { get; set; }


        public virtual User User { get; set; }

        public virtual Product Product { get; set; }
    }
}
