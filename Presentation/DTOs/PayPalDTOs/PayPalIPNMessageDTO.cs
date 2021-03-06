using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PayPalIPNMessageDTO
    {
        [JsonProperty("mc_gross")]
        public string mc_gross { get; set; }

        [JsonProperty("protection_eligibility")]
        public string protection_eligibility { get; set; }

        [JsonProperty("address_status")]
        public string address_status { get; set; }

        [JsonProperty("payer_id")]
        public string payer_id { get; set; }

        [JsonProperty("tax")]
        public string tax { get; set; }

        [JsonProperty("address_street")]
        public string address_street { get; set; }

        [JsonProperty("payment_date")]
        public string payment_date { get; set; }

        [JsonProperty("payment_status")]
        public string payment_status { get; set; }

        [JsonProperty("charset")]
        public string charset { get; set; }

        [JsonProperty("address_zip")]
        public string address_zip { get; set; }

        [JsonProperty("first_name")]
        public string first_name { get; set; }

        [JsonProperty("mc_fee")]
        public string mc_fee { get; set; }

        [JsonProperty("address_country_code")]
        public string address_country_code { get; set; }

        [JsonProperty("address_name")]
        public string address_name { get; set; }

        [JsonProperty("notify_version")]
        public string notify_version { get; set; }

        [JsonProperty("custom")]
        public string custom { get; set; }

        [JsonProperty("payer_status")]
        public string payer_status { get; set; }

        [JsonProperty("address_country")]
        public string address_country { get; set; }

        [JsonProperty("address_city")]
        public string address_city { get; set; }

        [JsonProperty("quantity")]
        public string quantity { get; set; }

        [JsonProperty("verify_sign")]
        public string verify_sign { get; set; }

        [JsonProperty("payment_email")]
        public string payment_email { get; set; }

        [JsonProperty("txn_id")]
        public string txn_id { get; set; }

        [JsonProperty("payment_type")]
        public string payment_type { get; set; }

        [JsonProperty("last_name")]
        public string last_name { get; set; }

        [JsonProperty("address_state")]
        public string address_state { get; set; }

        [JsonProperty("receiver_email")]
        public string receiver_email { get; set; }

        [JsonProperty("payment_fee")]
        public string payment_fee { get; set; }

        [JsonProperty("receiver_id")]
        public string receiver_id { get; set; }

        [JsonProperty("item_name")]
        public string item_name { get; set; }

        [JsonProperty("mc_currency")]
        public string mc_currency { get; set; }

        [JsonProperty("item_number")]
        public string item_number { get; set; }

        [JsonProperty("residence_country")]
        public string residence_country { get; set; }

        [JsonProperty("test_ipn")]
        public string test_ipn { get; set; }

        [JsonProperty("handling_amount")]
        public string handling_amount { get; set; }

        [JsonProperty("transaction_subject")]
        public string transaction_subject { get; set; }

        [JsonProperty("payment_gross")]
        public string payment_gross { get; set; }

        [JsonProperty("shipping")]
        public string shipping { get; set; }
    }
}
