using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
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
        private readonly IPasswordEncryptorService _passwordEncryptorService;

        public UserService(
            IUserRepository userRepository,
            IUserMapper userMapper,
            IPasswordEncryptorService passwordEncryptorService)
        {
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
            _passwordEncryptorService = passwordEncryptorService ?? throw new ArgumentException(nameof(passwordEncryptorService));
        }

        public async Task ChangePasswordAsync(string email, string password)
        {
            var existingUser = await _userRepository.GetByEmailAsync(email);
            if (existingUser == null)
            {
                throw new NotFoundException();
            }
            else if (!email.ToLower().Equals(existingUser.Email.ToLower()))
            {
                throw new NoPermissionException();
            }

            existingUser.PasswordHash = _passwordEncryptorService
                .CreateHash(password, existingUser?.PasswordSalt);

            await _userRepository.UpdateAsync(existingUser);
        }

        public async Task<User> GetByEmailAsync(string email) =>
            await _userRepository.GetByEmailAsync(email);

        public async Task<User> GetByIdAsync(Guid id) =>
            await _userRepository.GetByIdAsync(id);

        public async Task<User> GetByUserNameAsync(string userName) =>
             await _userRepository.GetByUserNameAsync(userName);

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

        public async Task ResetKreditAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency = 0;
            await _userRepository.UpdateAsync(user);
        }

        public async Task AddHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(hyCoinTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.HyCoin += Math.Abs(hyCoinTransactionDTO.HyCoin);
            await _userRepository.UpdateAsync(user);
        }

        public async Task RemoveHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(hyCoinTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var hyCoinAbs = Math.Abs(hyCoinTransactionDTO.HyCoin);

            if (user.HyCoin - hyCoinAbs >= 0)
            {
                user.HyCoin = 0;
            }
            else
            {
                user.HyCoin -= hyCoinAbs;
            }

            await _userRepository.UpdateAsync(user);
        }

        public async Task ResetHyCoinAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.HyCoin = 0;
            await _userRepository.UpdateAsync(user);
        }
    }
}
