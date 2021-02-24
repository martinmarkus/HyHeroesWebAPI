using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ProductDTO
    {
        [Required]
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        [Required]
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [Required]
        [JsonProperty("pricePerMonth")]
        public int PricePerMonth { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [Required]
        [JsonProperty("permanentPrice")]
        public int PermanentPrice { get; set; }

        [JsonProperty("singleGameServerId")]
        public string SingleGameServerId { get; set; }

#nullable enable
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("inGameActivatorCommand")]
        public string? InGameActivatorCommand { get; set; }

        [JsonProperty("inGameDeactivatorCommand")]
        public string? InGameDeactivatorCommand { get; set; }

        [JsonProperty("oneTimeCommand")]
        public string? OneTimeCommand { get; set; }
#nullable disable

        [JsonProperty("isRank")]
        public bool? IsRank { get; set; }
    }
}
