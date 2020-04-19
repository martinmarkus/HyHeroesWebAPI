using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException() : base ("This user is already registered.")
        {

        }
    }
}
