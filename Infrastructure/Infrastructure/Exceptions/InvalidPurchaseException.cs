using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class InvalidPurchaseException : Exception
    {
        public InvalidPurchaseException()
            : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.InvalidPurchase))
        {
        }
    }
}
