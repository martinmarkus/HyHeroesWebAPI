using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException()
            : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.UserAlreadyExists))
        {

        }
    }
}
