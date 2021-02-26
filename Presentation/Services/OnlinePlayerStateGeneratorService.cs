using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class OnlinePlayerStateGeneratorService : IOnlinePlayerStateGeneratorService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly int _interval;

        public OnlinePlayerStateGeneratorService(
            IServiceScopeFactory serviceScopeFactory,
            IOptions<AppSettings> options)
        {
            _serviceScopeFactory = serviceScopeFactory ?? throw new ArgumentException(nameof(serviceScopeFactory));

            if (options.Value.OnlinePlayerSimulatorInterval == -1)
            {
                return;
            }
            else if (options.Value.OnlinePlayerSimulatorInterval < 60)
            {
                _interval = 60;
            }
            else
            {
                _interval = options.Value.OnlinePlayerSimulatorInterval;
            }

            GenerateMockPlayerStateDataAsync().ConfigureAwait(true);
        }

        private async Task GenerateMockPlayerStateDataAsync()
        {
            using var scope = _serviceScopeFactory.CreateScope();

            var gameServerRepository = scope.ServiceProvider.GetService<IGameServerRepository>();
            var onlinePlayerStateRepository = scope.ServiceProvider.GetService<IOnlinePlayerStateRepository>();

            await InitWithStartingDataAsync(gameServerRepository, onlinePlayerStateRepository);

            while (true)
            {
                var serverIds = await gameServerRepository.GetAllRunningServerIdsAsync();
                foreach (var serverId in serverIds)
                {
                    var date = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH") + ":00");
                    await AddGeneratedPlayerStatAsync(onlinePlayerStateRepository, serverId, date);
                }

                await Task.Delay(_interval * 1000);
            }
        }

        private async Task InitWithStartingDataAsync(
            IGameServerRepository gameServerRepository,
            IOnlinePlayerStateRepository onlinePlayerStateRepository)
        {
            await onlinePlayerStateRepository.ClearAsync();

            for (int i = 1; i <= 10; i++)
            {
                var serverIds = await gameServerRepository.GetAllRunningServerIdsAsync();
                foreach (var serverId in serverIds)
                {
                    for (int j = 0; j < 24; j++)
                    {
                        var date = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH") + ":00").AddHours(-1 * j);
                        await AddGeneratedPlayerStatAsync(onlinePlayerStateRepository, serverId, date);
                    }
                }
            }
        }

        private async Task AddGeneratedPlayerStatAsync(
            IOnlinePlayerStateRepository onlinePlayerStateRepository,
            Guid serverId,
            DateTime date)
        {
            int random;

            if (date.Hour < 8 || date.Hour > 22)
            {
                random = new Random().Next(1, 15);
            }
            else if (date.Hour >= 8 && date.Hour < 14)
            {
                random = new Random().Next(15, 20);
            }
            else if (date.Hour >= 14 && date.Hour < 18)
            {
                random = new Random().Next(20, 35);
            }
            else
            {
                random = new Random().Next(30, 50);
            }

            await onlinePlayerStateRepository.AddAsync(new OnlinePlayerState()
            {
                CreationDate = date,
                GameServerId = serverId,
                OnlinePlayerCount = random
            });
        }
    }
}
