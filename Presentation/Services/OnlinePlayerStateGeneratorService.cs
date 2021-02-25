using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class OnlinePlayerStateGeneratorService : IOnlinePlayerStateGeneratorService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public OnlinePlayerStateGeneratorService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory ?? throw new ArgumentException(nameof(serviceScopeFactory));

            GenerateMockPlayerStateDataAsync().ConfigureAwait(true);
        }

        public async Task GenerateMockPlayerStateDataAsync()
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

                Thread.Sleep(60 * 1000);
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
                random = new Random().Next(15, 30);
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
