using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
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

        [Required]
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        //[Required]
        //[JsonProperty("productName")]
        //public string ProductName { get; set; }

        //[Required]
        //[JsonProperty("date")]
        //public DateTime Date { get; set; }

        [Required]
        [JsonProperty("PayPalTxnId")]
        public string PayPalTxnId { get; set; }

        //[Required]
        //[JsonProperty("isPaid")]
        //public bool IsPaid { get; set; }

        //[Required]
        //[JsonProperty("isBilled")]
        //public bool IsBilled { get; set; }

        //[Required]
        //[JsonProperty("isProductApplied")]
        //public bool IsProductApplied { get; set; }

        [Required]
        [JsonProperty("vevoAdoszam")]
        public string VevoAdoszam { get; set; }

        [Required]
        [JsonProperty("vevoSendEmail")]
        public string VevoSendEmail { get; set; }

        [Required]
        [JsonProperty("vevoAzonosito")]
        public string VevoAzonosito { get; set; }

        [Required]
        [JsonProperty("vevoEmail")]
        public string VevoEmail { get; set; }

        [Required]
        [JsonProperty("vevoMegjegyzes")]
        public string VevoMegjegyzes { get; set; }

        [Required]
        [JsonProperty("vevoTelefonszam")]
        public string VevoTelefonszam { get; set; }

        [Required]
        [JsonProperty("vevoNev")]
        public string VevoNev { get; set; }

        [Required]
        [JsonProperty("vevoIrsz")]
        public string VevoIrsz { get; set; }

        [Required]
        [JsonProperty("vevoTelepules")]
        public string VevoTelepules { get; set; }

        [Required]
        [JsonProperty("vevoCim")]
        public string VevoCim { get; set; }

        [Required]
        [JsonProperty("vevoPostazasiNev")]
        public string VevoPostazasiNev { get; set; }

        [Required]
        [JsonProperty("vevoPostazasiIrsz")]
        public string VevoPostazasiIrsz { get; set; }

        [Required]
        [JsonProperty("vevoPostazasiTelepules")]
        public string VevoPostazasiTelepules { get; set; }

        [Required]
        [JsonProperty("vevoPostazasiCim")]
        public string VevoPostazasiCim { get; set; }
    }
}
