using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class PermissionValidatorService : IPermissionValidatorService
    {
        public bool HasPermission(
            User user,
            PermissionLevel requiredPermissionLevel,
            string operationName)
        {
            if (user == null
                || user.Role == null)
            {
                throw new NotFoundException();
            }

            if (user.Role.PermissionLevel != requiredPermissionLevel)
            {
                if (string.IsNullOrEmpty(operationName))
                {
                    operationName = string.Empty;
                }

                throw new NoPermissionException(user.Email, operationName);
            }

            return true;
        }
    }
}
