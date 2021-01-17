using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class CustomAntiforgeryService : ICustomAntiforgeryService
    {
        private readonly IStringEncryptorService _stringEncryptorService;

        public CustomAntiforgeryService(IStringEncryptorService stringEncryptorService)
        {
            _stringEncryptorService = stringEncryptorService ?? throw new ArgumentException(nameof(stringEncryptorService));
        }

        public bool Validate(string baseValue, string encryptedValue, string salt)
        {
            try
            { 
                var assertEncryptedValue = _stringEncryptorService.CreateHash(
                    baseValue,
                    salt,
                    64);

                return assertEncryptedValue.Equals(
                    encryptedValue,
                    StringComparison.OrdinalIgnoreCase);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return false;
        }
    }
}
