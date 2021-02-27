using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("paypalipnmessages")]
    public class PayPalIPNMessage : BaseEntity
    {
        public decimal McGross { get; set; }

        public string ProtectionEligibility { get; set; }

        public string AddressStatus { get; set; }

        public string PayerId { get; set; }

        public decimal Tax { get; set; }

        public string AddressStreet { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymentStatus { get; set; }

        public string Charset { get; set; }

        public string AddressZip { get; set; }

        public string FirstName { get; set; }

        public decimal McFee { get; set; }

        public string AddressCountryCode { get; set; }

        public string AddressName { get; set; }

        public string NotifyVersion { get; set; }

        public string Custom { get; set; }

        public string PayerStatus { get; set; }

        public string AddressCountry { get; set; }

        public string AddressCity { get; set; }

        public int Quantity { get; set; }

        public string VerifySign { get; set; }

        public string PayerEmail { get; set; }

        public string TxnId { get; set; }

        public string PaymentType { get; set; }

        public string LastName { get; set; }

        public string AddressState { get; set; }

        public string ReceiverEmail { get; set; }

        public decimal PaymentFee { get; set; }

        public string ReceiverId { get; set; }

        public string ItemName { get; set; }

        public string McCurrency { get; set; }

        public string ItemNumber { get; set; }

        public string ResidenceCountry { get; set; }

        public string TestIpn { get; set; }

        public string HandlingAmount { get; set; }

        public string TransactionSubject { get; set; }

        public decimal PaymentGross { get; set; }

        public string Shipping { get; set; }
    }
}
