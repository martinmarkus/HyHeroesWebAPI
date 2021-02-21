using Hangfire;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PersistenceMaintainerService : IPersistenceMaintainerService
    {
        private readonly IOnlinePlayerStateRepository _onlinePlayerStateRepository;
        private readonly ILogger<object> _logger;
        public PersistenceMaintainerService(
            ILogger<object> logger,
            IOnlinePlayerStateRepository onlinePlayerStateRepository)
        {
            _logger = logger ?? throw new ArgumentException(nameof(logger));

            _onlinePlayerStateRepository = onlinePlayerStateRepository 
                ?? throw new ArgumentException(nameof(onlinePlayerStateRepository));
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
            var clearTask = _onlinePlayerStateRepository.CleanOutdatedAsync();
            clearTask.Wait();

            if (clearTask.Result > 0)
            {
                _logger.LogInformation(clearTask.Result
                    + " outdated Online Player States were removed at "
                    + DateTime.Now + ".");
            }
        }
    }
}
