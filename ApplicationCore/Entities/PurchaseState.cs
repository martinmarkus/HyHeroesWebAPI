﻿using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("purchasestates")]
    public class PurchaseState : BaseEntity
    {
        public bool IsActivationVerified { get; set; } = false;

        public bool IsExpirationVerified { get; set; } = false;

        public Guid GameServerId { get; set; }

        public Guid PurchasedProductId { get; set; }

        public virtual GameServer GameServer { get; set; }

        public virtual PurchasedProduct PurchasedProduct { get; set; }
    }
}
