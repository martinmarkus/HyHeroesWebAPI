using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PayPalLink
    {
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("rel")]
        public string Rel { get; set; }
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
