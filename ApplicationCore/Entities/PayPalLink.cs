using System;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PayPalLink : BaseEntity
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonIgnore]
        public Guid PayPalOrderId { get; set; }

        [JsonIgnore]
        public virtual PayPalOrder PayPalOrder { get; set; }
    }
}
