using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class IPBlacklistedException : Exception
    {
        public IPBlacklistedException(string IP) 
            : base(string.Format("IP {0} is blacklisted.", IP))
        {
        }
    }
}
