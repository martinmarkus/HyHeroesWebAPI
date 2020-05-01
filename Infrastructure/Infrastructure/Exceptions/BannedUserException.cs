using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class BannedUserException : Exception
    {
        public BannedUserException(string email)
            : base (string.Format("The user '{0}' is banned.", email))
        {
        }

        public BannedUserException()
             : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.Banned))
        {
        }
    }
}
