using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class IPValidatorService : IIPValidatorService
    {
        private readonly IOptions<AppSettings> _appSettings;
        private readonly IStringEncryptorService _stringEncryptorService;

        public IPValidatorService(
            IOptions<AppSettings> appSettings,
            IStringEncryptorService stringEncryptorService)
        {
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
            _stringEncryptorService = stringEncryptorService 
                ?? throw new ArgumentException(nameof(stringEncryptorService));
        }

        public bool ValidateToken(
            string assertIPToken,
            string userIP)
        {
            assertIPToken = assertIPToken.Trim();
            var validToken = GenerateToken(userIP);

            return assertIPToken.Equals(
                validToken,
                StringComparison.OrdinalIgnoreCase);
        }

        public string GenerateToken(string userIP) =>
            _stringEncryptorService.CreateHash(
                userIP,
                _appSettings.Value.IPValidatorSecretKey);
    }
}
