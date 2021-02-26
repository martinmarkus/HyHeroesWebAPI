using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class KreditGift : BaseEntity
    {
        [Required]
        public int KreditGiftAmount { get; set; }

        [Required]
        public Guid SenderUserId { get; set; }

        [Required]
        public Guid ReceiverUserId { get; set; }

        public virtual User SenderUser { get; set; }

        public virtual User ReceiverUser { get; set; }
    }
}
