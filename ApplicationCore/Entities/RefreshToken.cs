using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class RefreshToken : BaseEntity
    {
        [Required]
        public string TokenValue { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
