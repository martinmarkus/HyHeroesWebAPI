﻿using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PurchasedProduct : BaseEntity
    {
        public DateTime PurchaseDate { get; set; }

        public bool IsPermanent { get; set; }
        
        public bool IsVerified { get; set; }

        public bool IsExpirationVerified { get; set; }

        public int ValidityPeriodInMonths { get; set; }

        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }

        public virtual User User { get; set; }

        public virtual Product Product { get; set; }
    }
}
