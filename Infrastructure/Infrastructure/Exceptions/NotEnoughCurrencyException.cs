using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class NotEnoughCurrencyException : Exception
    {
        public NotEnoughCurrencyException(string email)
            : base(string.Format("The user {0} does not have enough currency for this operation.", email))
        {
        } 

        public NotEnoughCurrencyException()
        {
        }
    }
}
