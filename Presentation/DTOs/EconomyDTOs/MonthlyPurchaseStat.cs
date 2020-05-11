using System;

namespace HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs
{
    public class MonthlyPurchaseStat
    {
        public DateTime MonthDate { get; set; }

        public int PurchaseCount { get; set; }

        public int MonthlyIncome { get; set; }
    }
}
