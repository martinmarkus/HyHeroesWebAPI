using System;

namespace HyHeroesWebAPI.ApplicationCore.DataObjects
{
    public class KreditPurchaseNotification
    {
        public Guid UserId { get; set; }

        public int KreditValue { get; set; }

        public string PaymentType { get; set; }
    }
}
