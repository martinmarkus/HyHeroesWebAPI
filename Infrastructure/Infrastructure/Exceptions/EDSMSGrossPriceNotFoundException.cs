using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class EDSMSGrossPriceNotFoundException : Exception
    {
        public EDSMSGrossPriceNotFoundException(string missingGrossPrice) : base(missingGrossPrice)
        {
        }
    }
}
