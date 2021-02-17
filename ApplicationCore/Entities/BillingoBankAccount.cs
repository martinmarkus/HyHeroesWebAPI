using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoBankAccount : BaseEntity
    {
        [JsonProperty("id")]
        public string BillingoBankAccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("account_number_iban")]
        public string AccountNumberIban { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("need_qr")]
        public string NeeedQr { get; set; }
    }
}
