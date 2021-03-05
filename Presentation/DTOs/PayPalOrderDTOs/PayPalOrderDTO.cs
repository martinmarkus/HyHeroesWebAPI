﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalOrderDTO
    {
        public String intent { get; set; }
        public List<PayPalCreateOrderUnitDTO> purchase_units { get; set; }
    }
}
