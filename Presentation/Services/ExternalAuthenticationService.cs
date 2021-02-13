using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Utils;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ExternalAuthenticationService : IExternalAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IClientIdentityRepository _clientIdentityRepository;

        private readonly IAuthenticationService _authenticationService;

        private readonly IStringEncryptorService _stringEncryptorService;

        private readonly RandomStringGenerator<RandomCodeContainer> _randomStringGenerator;

        public ExternalAuthenticationService(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            IClientIdentityRepository clientIdentityRepository,
            IStringEncryptorService stringEncryptorService,
            IAuthenticationService authenticationService,
            RandomStringGenerator<RandomCodeContainer> randomStringGenerator)
        {
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _roleRepository = roleRepository ?? throw new ArgumentException(nameof(roleRepository));
            _clientIdentityRepository = clientIdentityRepository;

            _stringEncryptorService = stringEncryptorService ?? throw new ArgumentException(nameof(stringEncryptorService));
            _authenticationService = authenticationService ?? throw new ArgumentException(nameof(authenticationService));

            _randomStringGenerator = randomStringGenerator ?? throw new ArgumentException(nameof(randomStringGenerator));
        }

        public async Task ValidateExternalAuthenticationRangeAsync(ValidateAuthenticationByExternalListDTO userListDTO, string IP)
        {
            foreach (var user in userListDTO.AuthUsers)
            {
                await ValidateExternalAuthenticationAsync(user, IP);
            }
        }

        public async Task ValidateExternalAuthenticationAsync(ValidateAuthenticationByExternalDTO woodcraftUserDTO, string IP)
        {
            var user = await _userRepository.GetByEmailOrUserNameAsync(woodcraftUserDTO.UserName);
            var defaultRole = await _roleRepository.GetDefaultRoleAsnyc();

            var salt = _stringEncryptorService.CreateSalt();
            var encryptedHash = _stringEncryptorService.CreateHash(woodcraftUserDTO.Password, salt);

            if (user == null)
            {
                var addedUser = await _userRepository.AddAsync(new User()
                {
                    RoleId = defaultRole.Id,
                    UserName = woodcraftUserDTO.UserName,
                    PasswordHash = encryptedHash,
                    PasswordSalt = salt,
                    LastAuthenticationIp = IP
                });

                var baseValue = _randomStringGenerator.GetRandomString(128);
                var identitySalt = _randomStringGenerator.GetRandomString(64);
                var encrypted = _stringEncryptorService.CreateHash(baseValue, identitySalt);
                var newIdentity = new ClientIdentity()
                {
                    BaseValue = baseValue,
                    ValidatorSalt = identitySalt,
                    ValidatorHash = encrypted,
                    ExpirationDate = DateTime.Now.AddMinutes(60),
                    UserId = addedUser.Id,
                    User = addedUser
                };

                await _clientIdentityRepository.AddOrUpdateAsync(newIdentity);
            }
            else
            {
                user.PasswordHash = encryptedHash;
                user.PasswordSalt = salt;

                await _userRepository.UpdateAsync(user);
            }
        }
    }
}
