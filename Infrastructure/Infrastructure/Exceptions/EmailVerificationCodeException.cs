using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class EmailVerificationCodeException : Exception
    {
        public EmailVerificationCodeException(string code) 
            : base(string.Format(
                "The code '{0}' is invalid, or already used.", 
                code))
        {
        }
    }
}
