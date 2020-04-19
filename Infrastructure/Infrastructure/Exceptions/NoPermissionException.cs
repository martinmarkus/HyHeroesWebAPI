using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class NoPermissionException : Exception
    {
        public NoPermissionException(string email, string operation) 
            : base(string.Format(
                "The user {0} does not have enough permission for operation {1}.",
                email, operation))
        {
        }

        public NoPermissionException()
        {
        }
    }
}
