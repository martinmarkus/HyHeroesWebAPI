using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IAuthorizationService
    {
        Task<int> GetPermissionLevel(string roleName);

        Task<bool> HasPermissionAsync(Guid userId, string assertRoleName);

        Task<bool> HasPermissionAsync(User user, string assertRoleName);

        Task<bool> IsSelfAsync(string userEmail, Guid userId);
    }
}