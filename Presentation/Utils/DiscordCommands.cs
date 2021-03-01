using Discord.Commands;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Utils
{
    public class DiscordCommands : ModuleBase<SocketCommandContext>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly IServiceProvider _services;

        public DiscordCommands(
            IServiceProvider serviceProvider,
            IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _services = serviceProvider;
        }

        [Command("test")]
        public async Task Ping()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var userRepository = scope.ServiceProvider.GetService<IUserRepository>();
                var users = await userRepository.GetAllAsync();
                var msg = "HyHeroes Discord bot v1.0" + JsonConvert.SerializeObject(users);
                await ReplyAsync(msg);
            }
        }
    }
}
