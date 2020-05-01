using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PurchasedProductDTO
    {
        [Required]
        [JsonProperty("productName")]
        public string ProductName { get; set; }

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
        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [Required]
        [JsonProperty("isExpirationVerified")]
        public bool IsExpirationVerified { get; set; }

        [Required]
        [JsonProperty("validityPeriodInDays")]
        public int ValidityPeriodInDays { get; set; }

        [Required]
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [Required]
        [JsonProperty("permissionLevel")]
        public int PermissionLevel { get; set; }

        [Required]
        [JsonProperty("isBanned")]
        public bool IsBanned { get; set; }

        [Required]
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [Required]
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }
    }
}
