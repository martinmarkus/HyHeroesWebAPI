using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class MassKreditCodeAlreadyActivatedException : Exception
    {
        public MassKreditCodeAlreadyActivatedException(
            string code, 
            string userName) 
            : base(string.Format("Mass kredit code {0} is already activated for user {1}.", code, userName))
        {

        }
    }
}
