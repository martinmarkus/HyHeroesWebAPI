using Hangfire;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PersistenceMaintainerService : IPersistenceMaintainerService
    {
        private readonly IOnlinePlayerStateRepository _onlinePlayerStateRepository;
        private readonly IBackgroundJobClient _backgroundJobClient;

        public PersistenceMaintainerService(
            IOnlinePlayerStateRepository onlinePlayerStateRepository,
            IBackgroundJobClient backgroundJobClient)
        {
            _onlinePlayerStateRepository = onlinePlayerStateRepository 
                ?? throw new ArgumentException(nameof(onlinePlayerStateRepository));

            _backgroundJobClient = backgroundJobClient
                ?? throw new ArgumentException(nameof(backgroundJobClient));
        }

        public void StartOutdatedDataCleaner()
        {
            RecurringJob.AddOrUpdate(
                "Clean Outdated OnlinePlayer State Data",
                () => CleanOutdatedOnlinePlayerStateData(),
                Cron.Minutely);
        }

        public void CleanOutdatedOnlinePlayerStateData()
        {
            var clearTask = _onlinePlayerStateRepository.CleanOutdatedAsync();
            clearTask.Wait();

            if (clearTask.Result > 0)
            {
                Console.WriteLine("########");

                Console.WriteLine(clearTask.Result
                    + " outdated Online Player States were removed at "
                    + DateTime.Now + ".");

                Console.WriteLine("########");
            }
        }
    }
}
