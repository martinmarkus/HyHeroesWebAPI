using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUserRepository _userRepository;
        private IStringEncryptorService _passwordEncryptorService;

        public AuthenticationService(
            IUserRepository userRepository,
            IStringEncryptorService passwordEncryptorService)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _passwordEncryptorService = passwordEncryptorService ?? throw new ArgumentNullException(nameof(passwordEncryptorService));
        }

        public async Task<User> LoginAsync(LoginUser loginUser)
        {
            var user = await _userRepository.GetByEmailOrUserNameAsync(loginUser.EmailOrUserName);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            var passwordHash = _passwordEncryptorService.CreateHash(loginUser.Password, user.PasswordSalt);
            user = await _userRepository.GetByEmailOrUserNameAndPasswordAsync(loginUser.EmailOrUserName, passwordHash);

            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            if (user.IsBanned)
            {
                throw new BannedUserException(user.UserName);
            }

            user.LastAuthenticationDate = Convert.ToDateTime(loginUser.LastAuthenticationDate);
            user.LastAuthenticationIp =loginUser.LastAuthenticationIp;

            await _userRepository.UpdateAsync(user);

            return user;
        }

        public async Task<User> RegisterAsync(User user)
        {
            if (!string.IsNullOrEmpty(user.Email))
            {
                var existsByEmail = await _userRepository.UserExistsByEmailAsync(user.Email);
                if (existsByEmail)
                {
                    throw new EmailAlreadyExistsException();
                }
            }

            var existsByUserName = await _userRepository.UserExistsByUserNameAsync(user.UserName);
            if (existsByUserName)
            {
                throw new UserAlreadyExistsException();
            }
            else
            {
                return await _userRepository.AddAsync(user);
            }
        }

        public async Task<bool> UserAlreadyExists(NewUser newUser) =>
            await _userRepository.UserAlreadyExistsByNewUserAsync(newUser);
    }
 }
