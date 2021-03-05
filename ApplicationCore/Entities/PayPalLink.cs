using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PayPalLink : BaseEntity
    {
        [JsonIgnore]
        public Guid PayPalOrderId { get; set; }
        [JsonIgnore]
        public PayPalOrder PayPalOrder { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("rel")]
        public string Rel { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
