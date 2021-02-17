using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoDocumentSettings : BaseEntity
    {
        public bool MediatedService { get; set; }

        public bool WithoutFinancialFulfillment { get; set; }

        public string OnlinePayment { get; set; }

        public string Round { get; set; }

        public string OrderNumber { get; set; }

        public long PlaceId { get; set; }

        public virtual BillingoDocument BillingoDocument { get; set; }
    }
}
