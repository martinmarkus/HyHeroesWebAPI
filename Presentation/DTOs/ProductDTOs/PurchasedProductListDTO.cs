﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.ProductDTOs
{
    public class PurchasedProductListDTO
    {
        [JsonProperty("purchasedProducts")]
        public IList<PurchasedProductDTO> PurchasedProductDTOs { get; set; } = new List<PurchasedProductDTO>();
    }
}
