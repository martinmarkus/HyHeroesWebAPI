﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PayPalIPNDTO
    {
        [JsonProperty("mc_gross")]
        public string McGross { get; set; }

        [JsonProperty("protection_eligibility")]
        public string ProtectionEligibility { get; set; }

        [JsonProperty("address_status")]
        public string AddressStatus { get; set; }


        [JsonProperty("payer_id")]
        public string PayerId { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("address_street")]
        public string AddressStreet { get; set; }

        [JsonProperty("payment_date")]
        public string PaymentDate { get; set; }

        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }

        [JsonProperty("charset")]
        public string Charset { get; set; }

        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("mc_fee")]
        public string McFee { get; set; }

        [JsonProperty("address_country_code")]
        public string AddressCountryCode { get; set; }

        [JsonProperty("address_name")]
        public string AddressName { get; set; }

        [JsonProperty("notify_version")]
        public string NotifyVersion { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; } // important

        [JsonProperty("payer_status")]
        public string PayerStatus { get; set; }

        [JsonProperty("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("verify_sign")]
        public string VerifySign { get; set; }

        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        [JsonProperty("txn_id")]
        public string TxnId { get; set; }

        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("receiver_email")]
        public string ReceiverEmail { get; set; }

        [JsonProperty("payment_fee")]
        public string PaymentFee { get; set; }

        [JsonProperty("receiver_id")]
        public string ReceiverId { get; set; }

        [JsonProperty("txn_type")]
        public string TxnType { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("mc_currency")]
        public string McCurrency { get; set; }

        [JsonProperty("item_number")]
        public string ItemNumber { get; set; }

        [JsonProperty("residence_country")]
        public string ResidenceCountry { get; set; }

        [JsonProperty("test_ipn")]
        public string testIpn { get; set; }

        [JsonProperty("handling_amount")]
        public string HandlingAmount { get; set; }

        [JsonProperty("transaction_subject")]
        public string TransactionSubject { get; set; }

        [JsonProperty("payment_gross")]
        public string PaymentGross { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }
    }
}
