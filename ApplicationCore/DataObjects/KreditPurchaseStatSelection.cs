using System;

namespace HyHeroesWebAPI.ApplicationCore.DataObjects
{
    public class KreditPurchaseStatSelection
    {
        public string CreationDateMonth { get; set; }

        public int KreditValue { get; set; }

        public int CurrencyValue { get; set; }

        public int PurchaseCount { get; set; }
    }
}
