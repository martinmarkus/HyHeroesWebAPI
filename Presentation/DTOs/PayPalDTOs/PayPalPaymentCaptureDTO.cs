using System.Collections.Generic;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPaymentCaptureDTO
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        public PayPalCaptureStatusDTO StatusDetails { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public PayPalAmountDTO Amount { get; set; }

        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("seller_protection")]
        public PayPalSellerProtectionDTO SellerProtection { get; set; }

        [JsonProperty("final_capture")]
        public bool FinalCapture { get; set; }

        [JsonProperty("seller_receivable_breakdown")]
        public PayPalSellerReceivableBreakdownDTO SellerReceivableBreakdown { get; set; }

        [JsonProperty("disbursement_mode")]
        public string DisbursementMode { get; set; }

        [JsonProperty("links")]
        public List<PayPalLinkDTO> Links { get; set; }

        [JsonProperty("processor_response")]
        public PayPalProcessorResponseDTO ProcessorResponse { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }
    }
}
