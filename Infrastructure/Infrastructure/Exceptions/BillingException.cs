using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class BillingException : Exception
    {
        public BillingException()
            : base("A 'szamlazz.hu' billing request has returned with error.")
        {
        }
    }
}
