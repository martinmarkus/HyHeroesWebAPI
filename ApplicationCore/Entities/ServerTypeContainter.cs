using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public abstract class ServerTypeContainter : BaseEntity
    {
        [Required]
        public bool Lobby { get; set; } = false;

        [Required]
        public bool Survival { get; set; } = false;

        [Required]
        public bool Creative { get; set; } = false;

        [Required]
        public bool GTA { get; set; } = false;

        [Required]
        public bool PotterCraft { get; set; } = false;

        [Required]
        public bool OpSkyBlock { get; set; } = false;

        [Required]
        public bool SkyBoss { get; set; } = false;

        [Required]
        public bool Prison { get; set; } = false;

        [Required]
        public bool ComboFly { get; set; } = false;

        [Required]
        public bool Arcade { get; set; } = false;

        [Required]
        public Guid PurchasedProductId { get; set; }

        public virtual PurchasedProduct PurchasedProduct { get; set; }
    }
}
