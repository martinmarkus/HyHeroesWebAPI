using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalTokenService : IPayPalTokenService
    {
        private readonly IOptions<AppSettings> _appSettings;

        private PayPalToken _payPalToken;

        public PayPalTokenService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
        }

        public async Task<PayPalToken> GetToken()
        {
            if (_payPalToken == null)
            {
                return await GenerateToken();
            }

            if (DateTime.Compare(DateTime.Now, _payPalToken.Expiry) >= 0)
            {
                return await GenerateToken();
            }

            return _payPalToken;
        }

        public async Task<PayPalToken> GenerateToken()
        {
            try
            {
                var verificationRequest = WebRequest.Create("https://api-m.sandbox.paypal.com/v1/oauth2/token?grant_type=client_credentials");
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/x-www-form-urlencoded";
                verificationRequest.Headers.Add(
                    "Accept-Language",
                    "en_US");
                verificationRequest.Headers.Add(
                    "Authorization",
                    "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(_appSettings.Value.PayPalConfig.Client + ":" + _appSettings.Value.PayPalConfig.Secret)));

                using var reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream());
                var response = await reader.ReadToEndAsync();
                var jsonSerializerSettings = new JsonSerializerSettings();
                jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                _payPalToken = JsonConvert.DeserializeObject<PayPalToken>(response, jsonSerializerSettings);

                if (_payPalToken != null)
                {
                    // Levonunk 1 percet az Expiry-ből hogy mindig új tokent kapjunk és
                    // ne történjen olyan eset ahol pár másodperc lejárat előtt visszaadjuk a tokent.
                    _payPalToken.Expiry = DateTime.Now.Add(TimeSpan.FromSeconds(_payPalToken.ExpiryInSeconds)).Subtract(TimeSpan.FromMinutes(1));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new PayPalTokenException();
            }

            return _payPalToken;
        }
    }
}
