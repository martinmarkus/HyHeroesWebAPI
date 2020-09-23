using System;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class MonthlyPurchaseStatDTO
    {
        public DateTime MonthDate { get; set; }

        public int PurchaseCount { get; set; }

        public int MonthlyIncome { get; set; }

        public int MonthlyKreditSpent { get; set; }
    }
}
