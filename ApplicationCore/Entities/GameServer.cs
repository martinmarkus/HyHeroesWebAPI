using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class GameServer : BaseEntity
    {
        public string ServerName { get; set; }

        public bool IsServerRunning { get; set; }

        public virtual ICollection<PurchaseState> PurchaseStates { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<OnlinePlayerState> OnlinePlayerStates { get; set; }
    }
}
