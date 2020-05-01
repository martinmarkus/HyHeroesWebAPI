using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewPurchasedProductDTO
    {
        [Required]
        [JsonProperty("purchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [JsonProperty("isPermanent")]
        public bool IsPermanent { get; set; }

        [Required]
        [JsonProperty("isRepeatable")]
        public bool IsRepeatable { get; set; }

        [Required]
        [JsonProperty("validityPeriodInMonths")]
        public int ValidityPeriodInMonths { get; set; }

        [Required]
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [Required]
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }
    }
}
