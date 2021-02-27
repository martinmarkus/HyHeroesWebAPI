using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("kreditgifts")]
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
