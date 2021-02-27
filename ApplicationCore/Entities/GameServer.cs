using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("gameservers")]
    public class GameServer : BaseEntity
    {
        public string ServerName { get; set; }

        public bool IsServerRunning { get; set; }

        public virtual ICollection<PurchaseState> PurchaseStates { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<OnlinePlayerState> OnlinePlayerStates { get; set; }
    }
}
