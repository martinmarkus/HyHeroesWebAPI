﻿using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionIPNRequestDTO
    {
        public Guid POSKey { get; set; }

        public Guid PaymentId { get; set; }
    }
}
