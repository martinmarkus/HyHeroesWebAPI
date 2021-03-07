using System;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PayPalToken
    {
        [JsonProperty("access_token")]
        public string Token { get; set; }
        [JsonIgnore]
        public DateTime Expiry { get; set; }
        [JsonProperty("expires_in")]
        public int ExpiryInSeconds { get; set; }
    }
}
