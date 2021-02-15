using HyHeroesWebAPI.Presentation.DTOs.Interfaces;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HyHeroesWebAPI.Presentation.Comparers
{
    public class MonthlyStatComparer : IComparer<IComparablePurchaseStatDTO>
    {
        public int Compare([AllowNull] IComparablePurchaseStatDTO x, [AllowNull] IComparablePurchaseStatDTO y)
        {
            if (x == null || y == null)
            {
                return 0;
            }
            return x.MonthDate.CompareTo(y.MonthDate);
        }
    }
}
