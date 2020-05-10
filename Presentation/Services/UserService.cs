using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserMapper _userMapper;
        private readonly IPasswordEncryptorService _passwordEncryptorService;
        private readonly ValueConverter _valueConverter;

        public UserService(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            IUserMapper userMapper,
            IPasswordEncryptorService passwordEncryptorService,
            ValueConverter valueConverter)
        {
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _roleRepository = roleRepository ?? throw new ArgumentException(nameof(roleRepository));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
            _passwordEncryptorService = passwordEncryptorService ?? throw new ArgumentException(nameof(passwordEncryptorService));
            _valueConverter = valueConverter ?? throw new ArgumentException(nameof(valueConverter));
        }

        public async Task ChangePasswordAsync(string email, string oldPassword, string newPassword)
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

            var oldHash = _passwordEncryptorService.CreateHash(oldPassword, existingUser.PasswordSalt);
            if (!oldHash.Equals(existingUser.PasswordHash, StringComparison.Ordinal))
            {
                throw new WrongPasswordException();
            }

            existingUser.PasswordHash = _passwordEncryptorService
                .CreateHash(newPassword, existingUser?.PasswordSalt);

            await _userRepository.UpdateAsync(existingUser);
        }

        public async Task<User> GetByEmailAsync(string email) =>
            await _userRepository.GetByEmailAsync(email);

        public async Task<User> GetByIdAsync(Guid id) =>
            await _userRepository.GetByIdAsync(id);

        public async Task<User> GetByUserNameAsync(string userName) =>
             await _userRepository.GetByUserNameAsync(userName);

        public async Task<decimal> AddKreditAsync(KreditTransactionDTO kreditUploadDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(kreditUploadDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency += Math.Abs(kreditUploadDTO.KreditValue);
            await _userRepository.UpdateAsync(user);

            return user.Currency;
        }


        public async Task<decimal> RemoveKreditAsync(KreditTransactionDTO kreditTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(kreditTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var kreditAbs = Math.Abs(kreditTransactionDTO.KreditValue);

            if (user.Currency - kreditAbs >= 0)
            {
                user.Currency -= kreditAbs;
            }
            else
            {
                user.Currency = 0;
            }

            await _userRepository.UpdateAsync(user);

            return user.Currency;
        }

        public async Task<decimal> ResetKreditAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency = 0;
            await _userRepository.UpdateAsync(user);

            return user.Currency;
        }

        public async Task<int> AddHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(hyCoinTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.HyCoin += Math.Abs(hyCoinTransactionDTO.HyCoin);
            await _userRepository.UpdateAsync(user);

            return user.HyCoin;
        }

        public async Task<int> RemoveHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(hyCoinTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var hyCoinAbs = Math.Abs(hyCoinTransactionDTO.HyCoin);

            if (user.HyCoin - hyCoinAbs >= 0)
            {
                user.HyCoin -= hyCoinAbs;
            }
            else
            {
                user.HyCoin = 0;
            }

            await _userRepository.UpdateAsync(user);

            return user.HyCoin;
        }

        public async Task<int> ResetHyCoinAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.HyCoin = 0;
            await _userRepository.UpdateAsync(user);

            return user.HyCoin;
        }

        public async Task BanUserAsync(BanUserDTO banUserDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(banUserDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            if (user.IsBanned)
            {
                throw new UserAlreadyBannedException();
            }

            await _userRepository.BanUserAsync(banUserDTO.UserName);
        }

        public async Task<IList<ToplistElementDTO>> GetTopListAsync() =>
            _userMapper.MapToToplistElementDTOs(
                await _userRepository.GetAllForToplistAsync());

        public async Task<UserDTO> GetByUserNameOrEmailAsync(string userNameOrEmail) =>
            _userMapper.MapToUserDTO(
                await _userRepository.GetByEmailOrUserNameAsync(userNameOrEmail));

        public async Task UpdateUserAsync(UpdateUserDTO userDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(userDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency = _valueConverter.ConvertToInt(userDTO.Currency, user.Currency);
            user.HyCoin = _valueConverter.ConvertToInt(userDTO.HyCoin, user.HyCoin);
            user.IsBanned = _valueConverter.ConvertToBool(userDTO.IsBanned, user.IsBanned);

            var newRole = await _roleRepository.GetRoleByNameAsync(userDTO.RoleName);
            user.Role = newRole;
            user.RoleId = newRole.Id;

            await _userRepository.UpdateAsync(user);
        }

        public async Task<IList<RoleDTO>> GetAllRolesAsync()
        {
            var roles = await _roleRepository.GetAllAsync();
            var roleDTOs = new List<RoleDTO>();

            foreach (var role in roles)
            {
                roleDTOs.Add(new RoleDTO()
                { 
                    Name = role.Name
                });
            }

            return roleDTOs;
        }
    }
}
