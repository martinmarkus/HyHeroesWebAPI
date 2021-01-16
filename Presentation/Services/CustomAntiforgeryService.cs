using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class CustomAntiforgeryService : ICustomAntiforgeryService
    {
        private readonly IStringEncryptorService _stringEncryptorService;

        public CustomAntiforgeryService(IStringEncryptorService stringEncryptorService)
        {
            _stringEncryptorService = stringEncryptorService ?? throw new ArgumentException(nameof(stringEncryptorService));
        }

        public bool Validate(string baseAntiforgeryValue, string baseAntiforgeryKey, string encryptedAntiforgery)
        {
            try
            {
                var assertEncryptValue = _stringEncryptorService.CreateHMACSHA256(
                    baseAntiforgeryValue,
                    baseAntiforgeryKey);

                return assertEncryptValue.Equals(
                    encryptedAntiforgery,
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
