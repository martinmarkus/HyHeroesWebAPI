using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class AlreadyPurchasedException : Exception
    {
        public AlreadyPurchasedException()
        {

        }

        public AlreadyPurchasedException(string email, string product) 
            : base(string.Format("The product {0} is already purchased by {1}.", product, email))
        {
        }
    }
}
