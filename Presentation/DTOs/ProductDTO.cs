﻿using Newtonsoft.Json;
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
        [JsonProperty("pricePerMonth")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [JsonProperty("permanentPrice")]
        public decimal PermanentPrice { get; set; }

#nullable enable
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("inGameActivatorCommand")]
        public string? InGameActivatorCommand { get; set; }

        [JsonProperty("inGameDeactivatorCommand")]
        public string? InGameDeactivatorCommand { get; set; }
#nullable disable
    }
}
