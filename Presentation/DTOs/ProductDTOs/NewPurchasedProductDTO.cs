using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.ProductDTOs
{
    public class NewPurchasedProductDTO
    {
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

        // INFO: Start of Billing data

        //[Required]
        //[JsonProperty("userName")]
        //public string UserName { get; set; }

        //[Required]
        //[JsonProperty("fullName")]
        //public string FullName { get; set; }

        //[Required]
        //[JsonProperty("email")]
        //public string Email { get; set; }

        //[Required]
        //[JsonProperty("productName")]
        //public string ProductName { get; set; }

        //[Required]
        //[JsonProperty("date")]
        //public DateTime Date { get; set; }

        //[Required]
        //[JsonProperty("PayPalTxnId")]
        //public string PayPalTxnId { get; set; }

        //[Required]
        //[JsonProperty("isPaid")]
        //public bool IsPaid { get; set; }

        //[Required]
        //[JsonProperty("isBilled")]
        //public bool IsBilled { get; set; }

        //[Required]
        //[JsonProperty("isProductApplied")]
        //public bool IsProductApplied { get; set; }
    }
}
