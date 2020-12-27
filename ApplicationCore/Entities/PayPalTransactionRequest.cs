﻿using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PayPalTransactionRequest : BaseEntity
    {
        public bool IsRequestProcessed { get; set; }

        public Guid RequesterUserId { get; set; }

        public User RequesterUser { get; set; }
    }
}
