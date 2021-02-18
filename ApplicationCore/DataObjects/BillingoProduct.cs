using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.DataObjects
{
    [NotMapped]
    public class BillingoProduct
    {
        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("vat")]
        public string Vat { get; set; }

        [JsonProperty("unit_price")]
        public int UnitPrice { get; set; }

        [JsonProperty("unit_price_type")]
        public string UnitPriceType { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("entitlement")]
        public string Entitlement { get; set; }
    }
}
