using HyHeroesWebAPI.Infrastructure.Infrastructure.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException()
             : base(Enum.GetName(typeof(ExceptionEnum), ExceptionEnum.NotFound))
        {
        }
    }
}
