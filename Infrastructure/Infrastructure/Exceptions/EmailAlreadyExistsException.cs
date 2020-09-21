using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class EmailAlreadyExistsException : Exception
    {
        public EmailAlreadyExistsException()
            : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.EmailAlreadyExists))
        {
        }
    }
}
