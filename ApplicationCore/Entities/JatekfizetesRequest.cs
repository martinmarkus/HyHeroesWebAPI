using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("jatekfizetesrequests")]
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
