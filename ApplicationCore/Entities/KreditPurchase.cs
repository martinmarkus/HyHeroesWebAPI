using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class KreditPurchase : BaseEntity
    {
        public int KreditValue { get; set; }

        public int CurrencyValue { get; set; }

        public PaymentType PaymentType { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<EDSMSPurchase> EDSMSPurchases { get; set; }
    }

}
