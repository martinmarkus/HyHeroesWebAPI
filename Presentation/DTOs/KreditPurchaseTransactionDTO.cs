using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class KreditPurchaseTransactionDTO
    {
        [Required]
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [Required]
        [JsonProperty("currencyValue")]
        public int CurrencyValue { get; set; }


        // INFO billing fields
        [Required]
        [JsonProperty("paymentType")]
        public PaymentType PaymentType { get; set; }

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
