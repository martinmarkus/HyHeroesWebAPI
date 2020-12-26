using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class GameServer : BaseEntity
    {
        public string ServerName { get; set; }

        public bool IsServerRunning { get; set; }

        public DateTime TimeStamp { get; set; }

        public virtual ICollection<PurchaseState> PurchaseStates { get; set; }
    }
}
