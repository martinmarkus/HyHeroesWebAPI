using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewCategoryDTO
    {
        [Required]
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [Required]
        [JsonProperty("priority")]
        public int Priority { get; set; }

        [Required]
        [JsonProperty("isUsed")]
        public bool IsUsed { get; set; }

        [Required]
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
