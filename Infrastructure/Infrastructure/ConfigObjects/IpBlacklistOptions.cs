namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public class IpBlacklistOptions
    {
        public int DangerousCallCount { get; set; }

        public int DangerousMillisecsBetweenCalls { get; set; }
    }
}
