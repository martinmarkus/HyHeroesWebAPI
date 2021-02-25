using Hangfire;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PersistenceMaintainerService : IPersistenceMaintainerService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public PersistenceMaintainerService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;

            StartOutdatedDataCleaner();
        }

        public void StartOutdatedDataCleaner()
        {
            try
            {
                RecurringJob.AddOrUpdate(
                    "Clean Outdated OnlinePlayer State Data",
                    () => CleanOutdatedOnlinePlayerStateData(),
                    Cron.Daily);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CleanOutdatedOnlinePlayerStateData()
        {
            try
            {
                using var scope = _serviceScopeFactory.CreateScope();

                var logger = scope.ServiceProvider.GetService<ILogger<object>>();
                var onlinePlayerStateRepository = scope.ServiceProvider.GetService<IOnlinePlayerStateRepository>();

                var clearTask = onlinePlayerStateRepository.CleanOutdatedAsync();
                clearTask.Wait();

                if (clearTask.Result > 0)
                {
                    logger.LogInformation(clearTask.Result
                        + " outdated Online Player States were removed at "
                        + DateTime.Now + ".");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }                     
        }
    }
}
