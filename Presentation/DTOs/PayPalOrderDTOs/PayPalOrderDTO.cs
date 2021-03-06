using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalOrderDTO
    {
        public String intent { get; set; }

        public List<PayPalCreateOrderUnitDTO> purchase_units { get; set; }
    }
}
