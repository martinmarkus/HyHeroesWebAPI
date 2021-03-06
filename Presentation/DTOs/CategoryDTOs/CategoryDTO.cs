using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.CategoryDTOs
{
    public class CategoryDTO
    {
        [JsonProperty("categoryId")]
        public Guid? CategoryId { get; set; }

        [Required]
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [Required]
        [JsonProperty("priority")]
        public int Priority { get; set; }

        [Required]
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
