﻿using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class AppSettings
    {
        public string SecretKey { get; set; }

        public SellerData SellerData { get; set; }

        public IList<EDSMSPurchaseTypeDTO> EDSMSPurchaseTypes { get; set; }

        public PayPalConfig PayPalConfig { get; set; }
    }
}
