using Hangfire;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

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
            //_backgroundJobClient.Schedule(() => 
            //CleanOutdatedOnlinePlayerStateDataAsync(),
            //TimeSpan.FromSeconds(10));

            RecurringJob.AddOrUpdate(
                "CleanOutdatedOnlinePlayerStateData",
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
