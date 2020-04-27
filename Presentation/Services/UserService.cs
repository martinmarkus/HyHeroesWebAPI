using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserMapper _userMapper;


        public UserService(
            IUserRepository userRepository,
            IUserMapper userMapper)
        {
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));

        }

        public async Task AddKreditAsync(KreditTransactionDTO kreditUploadDTO)
        {
            var user = await _userRepository.GetByIdAsync(kreditUploadDTO.UserId);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency += Math.Abs(kreditUploadDTO.KreditValue);
            await _userRepository.UpdateAsync(user);
        }

        public async Task<User> GetByEmailAsync(string email) =>
            await _userRepository.GetByEmailAsync(email);

        public async Task<User> GetByIdAsync(Guid id) =>
            await _userRepository.GetByIdAsync(id);

        public async Task RemoveKreditAsync(KreditTransactionDTO kreditTransactionDTO)
        {
            var user = await _userRepository.GetByIdAsync(kreditTransactionDTO.UserId);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var kreditAbs = Math.Abs(kreditTransactionDTO.KreditValue);

            if (user.Currency - kreditAbs >= 0)
            {
                user.Currency = 0;
            }
            else
            {
                user.Currency -= kreditAbs;
            }

            await _userRepository.UpdateAsync(user);
        }

        public async Task ResetKreditAsync(Guid userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency = 0;
            await _userRepository.UpdateAsync(user);
        }

        public async Task UpdateUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
