using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class JatekfizetesRequest : BaseEntity
    {
        [Required]
        public string ClientIP { get; set; }

        [Required]
        public DateTime CallDate { get; set; }

        [Required]
        public bool IsActivationSuccessful { get; set; }

        [Required]
        public Guid CallerUserId { get; set; }

        public virtual User CallerUser { get; set; }
    }
}
