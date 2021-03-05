using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalCreateOrderUnitDTO
    {
        public PayPalCreateOrderAmountDTO amount { get; set; }
        public string description { get; set; }
    }
}
