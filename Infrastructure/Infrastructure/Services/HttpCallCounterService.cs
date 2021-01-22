using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class HttpCallCounterService : IHttpCallCounterService
    {
        private static ConcurrentDictionary<string, DateTime> LoginTries = new ConcurrentDictionary<string, DateTime>();

        private readonly IBlacklistedIPRepository _blacklistedIPRepository;

        public int DangerousCallCount { get; set; } = 50;

        public int DangerousMillisecsBetweenCalls { get; set; } = 50;

        public CancellationTokenSource _tokenSource = new CancellationTokenSource();

        public HttpCallCounterService(IBlacklistedIPRepository blacklistedIPRepository)
        {
            _blacklistedIPRepository = blacklistedIPRepository ?? throw new ArgumentException(nameof(blacklistedIPRepository));
        }

        public void StartLoginTriesValidation()
        {
            StartLoginTriesValidation(RefreshIPBag, DangerousMillisecsBetweenCalls, _tokenSource.Token);
        }

        public async Task<bool> AddCallTryAsync(string IPValue)
        {
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

            LoginTries.TryAdd(
                IPValue,
                DateTime.Now);

            return true;
        }

        private void RefreshIPBag()
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

        private static void StartLoginTriesValidation(Action action, int milliseconds, CancellationToken token)
        {
            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        action();
                        await Task.Delay(TimeSpan.FromMilliseconds(milliseconds), token);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            }, token);
        }
    }
}
