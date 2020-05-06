using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException() 
            : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.WrongPassword))
        {
        }
    }
}
