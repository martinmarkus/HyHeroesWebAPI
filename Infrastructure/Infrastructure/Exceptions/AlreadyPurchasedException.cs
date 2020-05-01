using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class AlreadyPurchasedException : Exception
    {
        public AlreadyPurchasedException() : base (Enum.GetName(typeof(ExceptionEnum),ExceptionEnum.AlreadyPurchased))
        {

        }

        public AlreadyPurchasedException(string email, string product) 
            : base(string.Format("The product {0} is already purchased by {1}.", product, email))
        {
        }
    }
}
