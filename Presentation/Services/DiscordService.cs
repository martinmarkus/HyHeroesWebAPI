using Discord;
using Discord.Commands;
using Discord.WebSocket;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class DiscordService : IDiscordService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        private DiscordSocketClient _discordSocketClient;
        private CommandService _commandService;
        private IServiceProvider _services;

        private readonly string _token;
        private readonly string _prefix;
        private readonly ulong _staffChannelId;
        private readonly ulong _newsChannelId;
        private readonly bool _useDiscord;

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

            // INFO: getting discord settings
            using var scope = _serviceScopeFactory.CreateScope();
            var options = scope.ServiceProvider.GetService<IOptions<AppSettings>>();
            var tokenBytes = Convert.FromBase64String(options.Value.DiscordSettings.BotTokenBase64);

            _token = Encoding.UTF8.GetString(tokenBytes);
            _prefix = options.Value.DiscordSettings.CommandPrefix;
            _staffChannelId = options.Value.DiscordSettings.PrivateStaffChannelId;
            _newsChannelId = options.Value.DiscordSettings.PublicNewsChannelId;
            _useDiscord = options.Value.DiscordSettings.UseDiscordIntegration;
        }

        public async Task RunBotAsync()
        {
            if (!_useDiscord)
            {
                return;
            }

            try
            {
                await RegisterCommandsAsnyc();
                await _discordSocketClient.LoginAsync(TokenType.Bot, _token);
                await _discordSocketClient.StartAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private async Task RegisterCommandsAsnyc()
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
            if (message.HasStringPrefix(_prefix, ref argPos))
            {
                var isProcessed = await TryProcessAsParameterizedCommandAsync(message);
                if (isProcessed)
                {
                    return;
                }

                var result = await _commandService.ExecuteAsync(context, argPos, _services);

                if (!result.IsSuccess)
                {
                    Console.WriteLine(result.Error);
                }
            }
        }

        private async Task<bool> TryProcessAsParameterizedCommandAsync(SocketUserMessage message)
        {
            var splitedParams = message.Content.Split(new string[] { _prefix }, StringSplitOptions.None);
            if (splitedParams.Length <= 1 || string.IsNullOrEmpty(splitedParams[1]))
            {
                return false;
            }

            try
            {
                using var scope = _serviceScopeFactory.CreateScope();
                var options = scope.ServiceProvider.GetService<IOptions<AppSettings>>();

                foreach (var customCommand in options.Value.DiscordSettings.CustomCommands)
                {
                    if (customCommand.Command.Equals(splitedParams[1], StringComparison.OrdinalIgnoreCase))
                    {
                        await message.Author.SendMessageAsync(
                             customCommand.ResponseText,
                             false,
                             null,
                             null,
                             null);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public async Task SendMessageToStaffAsync(string msg = "") =>
            await SendMessageToChannelAsync(_staffChannelId, @msg + "\n@here");

        public async Task SendMessageToNewsAsync(string msg = "") =>
            await SendMessageToChannelAsync(_newsChannelId, @msg + "\n@everyone");

        public async Task SendMessageToChannelAsync(ulong channelId, string msg)
        {
            if (!_useDiscord || string.IsNullOrEmpty(msg))
            {
                return;
            }

            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var env = scope.ServiceProvider.GetService<IWebHostEnvironment>();
                if (env.EnvironmentName.Equals("Development"))
                {
                    msg += "\n(From dev environment)";
                }
            }

            var channel = _discordSocketClient.GetChannel(channelId) as SocketTextChannel;
            await channel.SendMessageAsync(
                Regex.Replace(@msg, "<.*?>", "\n"), 
                false,
                null,
                null,
                new AllowedMentions(AllowedMentionTypes.Everyone));
        }
    }
}
