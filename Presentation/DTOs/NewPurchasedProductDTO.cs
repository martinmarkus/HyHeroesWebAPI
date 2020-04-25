using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewPurchasedProductDTO
    {
        public DateTime PurchaseDate { get; set; }

        public bool IsPermanent { get; set; }

        public int ValidityPeriodInMonths { get; set; }

        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }
    }
}
