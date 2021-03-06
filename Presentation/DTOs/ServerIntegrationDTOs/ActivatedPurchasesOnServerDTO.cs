using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.ServerIntegrationDTOs
{
    public class ActivatedPurchasesOnServerDTO
    {
        public IList<Guid> PurchasedProductIds { get; set; }

        public Guid GameServerId { get; set; }
    }
}
