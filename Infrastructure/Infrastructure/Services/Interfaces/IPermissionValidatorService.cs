using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IPermissionValidatorService
    {
        bool HasPermission(User user,
            int requiredPermissionLevel,
            string operationName);
    }
}