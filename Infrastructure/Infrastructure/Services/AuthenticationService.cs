using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Utils;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IClientIdentityRepository _clientIdentityRepository;
        private readonly IStringEncryptorService _stringEncryptorService;
        private readonly RandomStringGenerator<RandomCodeContainer> _randomStringGenerator;

        public AuthenticationService(
            IUserRepository userRepository,
            IStringEncryptorService passwordEncryptorService,
            IClientIdentityRepository clientIdentityRepository,
            RandomStringGenerator<RandomCodeContainer> randomStringGenerator)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _stringEncryptorService = passwordEncryptorService ?? throw new ArgumentNullException(nameof(passwordEncryptorService));
            _clientIdentityRepository = clientIdentityRepository ?? throw new ArgumentNullException(nameof(clientIdentityRepository));
            _randomStringGenerator = randomStringGenerator ?? throw new ArgumentNullException(nameof(randomStringGenerator));
        }

        public async Task<User> LoginAsync(LoginUser loginUser)
        {
            var user = await _userRepository.GetByEmailOrUserNameAsync(loginUser.EmailOrUserName);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            var passwordHash = _stringEncryptorService.CreateHash(loginUser.Password, user.PasswordSalt);
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
            user.LastAuthenticationIp = loginUser.LastAuthenticationIp;

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
                var baseValue = _randomStringGenerator.GetRandomString(128);
                var salt = _randomStringGenerator.GetRandomString(64);
                var encrypted = _stringEncryptorService.CreateHash(baseValue, salt);

                var newIdentity = new ClientIdentity()
                {
                    BaseValue = baseValue,
                    ValidatorSalt = salt,
                    ValidatorHash = encrypted,
                    ExpirationDate = DateTime.Now.AddMinutes(60),
                    UserId = user.Id,
                    User = user
                };

                await _clientIdentityRepository.AddOrUpdateAsync(newIdentity);
                return await _userRepository.AddAsync(user);
            }
        }

        public async Task<bool> UserAlreadyExists(NewUser newUser) =>
            await _userRepository.UserAlreadyExistsByNewUserAsync(newUser);
    }
 }
