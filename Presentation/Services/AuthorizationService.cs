using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        public AuthorizationService(
            IUserRepository userRepository,
            IRoleRepository roleRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }

        public async Task<bool> HasPermissionAsync(
            Guid userId,
            string assertRoleName)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var assertPermissionLevel = await GetPermissionLevel(assertRoleName);
            return user.Role.PermissionLevel >= assertPermissionLevel;
        }

        public async Task<bool> HasPermissionAsync(
            User user,
            string assertRoleName)
        {
            if (user == null || user.Role == null)
            {
                throw new NotFoundException();
            }

            var assertPermissionLevel = await GetPermissionLevel(assertRoleName);
            return user.Role.PermissionLevel >= assertPermissionLevel;
        }

        public async Task<int> GetPermissionLevel(string roleName)
        {
            var role = await _roleRepository.GetRoleByNameAsync(roleName);
            if (role == null)
            {
                throw new NotFoundException();
            }

            return role.PermissionLevel;
        }

        public async Task<bool> IsSelfAsync(string userEmail, Guid userId)
        {
            var user = await _userRepository.GetByEmailAsync(userEmail);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            return user?.Id == userId;
        }
    }
}
