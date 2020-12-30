using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ReactivatePermanentRankDTO
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName{ get; set; }

        [Required]
        public Guid PermanentPurchaseId { get; set; }
    }
}
