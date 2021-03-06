using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.CategoryDTOs
{
    public class CategoryListDTO
    {
        [JsonProperty("categories")]
        public IList<CategoryDTO> Categories { get; set; }
    }
}
