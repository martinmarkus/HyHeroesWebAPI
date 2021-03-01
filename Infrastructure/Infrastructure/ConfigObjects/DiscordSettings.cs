namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public class DiscordSettings
    {
        public  string BotTokenBase64 { get; set; }

        public ulong PublicNewsChannelId { get; set; }

        public ulong PrivateStaffChannelId { get; set; }

        public ulong[] StaffRoleIds { get; set; }
    }
}
