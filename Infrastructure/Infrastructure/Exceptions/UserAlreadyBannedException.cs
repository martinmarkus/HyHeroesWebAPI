using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class UserAlreadyBannedException : Exception
    {
        public UserAlreadyBannedException(string email)
        : base(string.Format("The user '{0}' is already banned.", email))
        {
        }

        public UserAlreadyBannedException()
            : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.AlreadyBanned))
        {
        }
    }
}
