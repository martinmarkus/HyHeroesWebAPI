using HyHeroesWebAPI.ApplicationCore.Enums;
using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PurchaseState : BaseEntity
    {
        public bool IsActivationVerified { get; set; }

        public bool IsExpirationVerified { get; set; }

        public Guid GameServerId { get; set; }

        public Guid PurchasedProductId { get; set; }

        public virtual GameServer GameServer { get; set; }

        public virtual PurchasedProduct PurchasedProduct { get; set; }
    }
}
