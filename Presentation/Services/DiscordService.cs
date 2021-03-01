using Discord;
using Discord.Commands;
using Discord.WebSocket;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class DiscordService : IDiscordService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly string _token;

        private DiscordSocketClient _discordSocketClient;
        private CommandService _commandService;
        private IServiceProvider _services;

        public DiscordService(
            IServiceScopeFactory serviceScopeFactory,
            DiscordSocketClient discordSocketClient,
            CommandService commandService,
            IServiceProvider services)
        {
            _discordSocketClient = discordSocketClient;
            _commandService = commandService;
            _services = services;

            _serviceScopeFactory = serviceScopeFactory ?? throw new ArgumentException(nameof(serviceScopeFactory));
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var tokenBytes = Convert.FromBase64String(scope.ServiceProvider.GetService<IOptions<AppSettings>>()
                    .Value.DiscordBotTokenBase64);
                _token = Encoding.UTF8.GetString(tokenBytes);
            }
        }

        public async Task RunBotAsync()
        {
            _discordSocketClient.Log += LogAsync;
            await RegisterCommandsAsnyc();
            await _discordSocketClient.LoginAsync(TokenType.Bot, _token);
            await _discordSocketClient.StartAsync();
        }

        private Task LogAsync(LogMessage msg)
        {
            Console.WriteLine(msg);
            return Task.CompletedTask;
        }

        public async Task RegisterCommandsAsnyc()
        {
            _discordSocketClient.MessageReceived += HandleCommandAsync;

            await _commandService.AddModulesAsync(
                Assembly.GetEntryAssembly(),
                _services);
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_discordSocketClient, message);

            if (message.Author.IsBot)
            {
                return;
            }

            var argPos = 0;
            if (message.HasStringPrefix("!hh", ref argPos))
            {
                var result = await _commandService.ExecuteAsync(context, argPos, _services);
                if (!result.IsSuccess)
                {
                    Console.WriteLine(result.Error);
                }
            }
        }
    }
}
