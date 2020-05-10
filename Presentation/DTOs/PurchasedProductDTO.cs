using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PurchasedProductDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [Required]
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [Required]
        [JsonProperty("pricePerMonth")]
        public int PricePerMonth { get; set; }

        [Required]
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [Required]
        [JsonProperty("permanentPrice")]
        public int PermanentPrice { get; set; }

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
        [JsonProperty("validityPeriodInMonths")]
        public int ValidityPeriodInMonths { get; set; }

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
        [JsonProperty("isRank")]
        public bool IsRank { get; set; }

        [Required]
        [JsonProperty("isOverwrittenByOtherRank")]
        public bool IsOverwrittenByOtherRank { get; set; }

        [Required]
        [JsonProperty("actualValueOfOneKredit")]
        public decimal ActualValueOfOneKredit { get; set; }

        [Required]
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [Required]
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }
    }
}
