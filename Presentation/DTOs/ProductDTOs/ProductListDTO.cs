using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.ProductDTOs
{
    public class ProductListDTO
    {
        [JsonProperty("products")]
        public IList<ProductDTO> Products { get; set; }
    }
}
