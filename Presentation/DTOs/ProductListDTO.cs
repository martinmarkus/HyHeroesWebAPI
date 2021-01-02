﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ProductListDTO
    {
        [JsonProperty("products")]
        public IList<ProductDTO> ProductDTOs { get; set; }
    }
}