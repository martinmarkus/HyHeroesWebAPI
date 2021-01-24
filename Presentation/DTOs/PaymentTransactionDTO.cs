using BarionClientLibrary.Operations.Common;
using BarionClientLibrary.Operations.StartPayment;
using System;
using System.Globalization;
using System.Net.Http;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PaymentTransactionDTO
    {
        public Uri RelativeUri { get; }
        public ChallengePreference ChallengePreference { get; set; }
        public PurchaseInformation PurchaseInformation { get; set; }
        public PayerAccountInformation PayerAccount { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public string PayerHomeNumber { get; set; }
        public string PayerWorkPhoneNumber { get; set; }
        public string PayerPhoneNumber { get; set; }
        public Currency Currency { get; set; }
        public CultureInfo Locale { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public string OrderNumber { get; set; }
        public HttpMethod Method { get; }
        public PaymentTransaction[] Transactions { get; set; }
        public string RedirectUrl { get; set; }
        public RecurrenceType? RecurrenceType { get; set; }
        public string CardHolderNameHint { get; set; }
        public string PayerHint { get; set; }
        public string PaymentRequestId { get; set; }
        public FundingSourceType[] FundingSources { get; set; }
        public string RecurrenceId { get; set; }
        public bool InitiateRecurrence { get; set; }
        public bool GuestCheckOut { get; set; }
        public TimeSpan? PaymentWindow { get; set; }
        public TimeSpan? ReservationPeriod { get; set; }
        public PaymentType PaymentType { get; set; }
        public string CallbackUrl { get; set; }
        public Type ResultType { get; }
    }
}
