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
        private IPasswordEncryptorService _passwordEncryptorService;

        public AuthenticationService(
            IUserRepository userRepository,
            IPasswordEncryptorService passwordEncryptorService)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _passwordEncryptorService = passwordEncryptorService ?? throw new ArgumentNullException(nameof(passwordEncryptorService));
        }

        public async Task<User> LoginAsync(
            string emailOrUserName, 
            string password)
        {
            if (string.IsNullOrEmpty(emailOrUserName) || string.IsNullOrEmpty(password))
            {
                throw new UnauthorizedAccessException();
            }

            var user = await _userRepository.GetByEmailOrUserNameAsync(emailOrUserName);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            var passwordHash = _passwordEncryptorService.CreateHash(password, user.PasswordSalt);
            user = await _userRepository.GetByEmailOrUserNameAndPasswordAsync(emailOrUserName, passwordHash);

            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            if (user.IsBanned)
            {
                throw new BannedUserException(user.UserName);
            }

            return user;
        }

        public async Task<User> RegisterAsync(User user)
        {
            var exists = await _userRepository.UserExistsByEmailOrUserName(user.Email, user.UserName);

            if (!exists)
            {
                return await _userRepository.AddAsync(user);
            }
            else
            {
                throw new UserAlreadyExistsException();
            }
        }

        public async Task<bool> UserAlreadyExists(NewUser newUser) =>
            await _userRepository.UserAlreadyExistsByNewUserAsync(newUser);
    }
 }
