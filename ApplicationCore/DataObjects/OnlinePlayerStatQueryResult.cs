using System;

namespace HyHeroesWebAPI.ApplicationCore.DataObjects
{
    public class OnlinePlayerStatQueryResult
    {
        public DateTime CreationDate { get; set; }

        public string GameServerId { get; set; }

        public int PlayerCount { get; set; }
    }
}
