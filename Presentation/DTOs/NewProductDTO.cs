using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewProductDTO
    {
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
    }
}
