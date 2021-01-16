using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class InvalidIPException : Exception
    {
        public InvalidIPException(string assertToken, string userIP) 
            : base(string.Format("Request client IP Token: {0}. Request IP: {1}", assertToken, userIP))
        {
        }
    }
}
