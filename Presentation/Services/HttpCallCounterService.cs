using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class HttpCallCounterService : IHttpCallCounterService
    {
        private static ConcurrentDictionary<string, DateTime> LoginTries = new ConcurrentDictionary<string, DateTime>();

        private readonly IBlacklistedIPRepository _blacklistedIPRepository;
        private readonly IOptions<AppSettings> _appSettings;

        public int DangerousCallCount { get; set; } = 50;
        public int DangerousMillisecsBetweenCalls { get; set; } = 50;

        public HttpCallCounterService(
            IBlacklistedIPRepository blacklistedIPRepository,
            IOptions<AppSettings> appSettings)
        {
            _blacklistedIPRepository = blacklistedIPRepository ?? throw new ArgumentException(nameof(blacklistedIPRepository));
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));

            DangerousCallCount = _appSettings.Value.IpBlacklistOptions.DangerousCallCount;
            DangerousMillisecsBetweenCalls = _appSettings.Value.IpBlacklistOptions.DangerousMillisecsBetweenCalls;
        }

        public async Task<bool> AddCallTryAsync(string IPValue)
        {
            RemoveExpiredCallData();

            var tryCount = LoginTries.Count(login => login.Key.Equals(IPValue, StringComparison.OrdinalIgnoreCase));

            if (tryCount > DangerousCallCount)
            {
                // INFO: flood detected
                await _blacklistedIPRepository.AddAsync(new BlacklistedIP()
                {
                    IP = IPValue
                });

                return false;
            }
            try
            {
                LoginTries.TryAdd(
                    IPValue,
                    DateTime.Now);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }

        private void RemoveExpiredCallData()
        {
            try
            {
                var itemsToRemove = LoginTries
                    .Where(element => element.Value < DateTime.Now.AddMilliseconds(-1 * DangerousMillisecsBetweenCalls))
                    .ToArray();

                foreach (var item in itemsToRemove)
                {
                    var successfullyRemoved = LoginTries.Remove(item.Key, out DateTime value);
                    if (!successfullyRemoved)
                    {
                        LoginTries.Clear();
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                LoginTries.Clear();
            }
        }
    }
}
