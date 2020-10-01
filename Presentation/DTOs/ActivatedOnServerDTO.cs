﻿using HyHeroesWebAPI.ApplicationCore.Enums;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ActivatedOnServerDTO
    {
        public Guid PurchasedProductId { get; set; }
        public string ServerName { get; set; }
    }
}
