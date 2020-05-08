using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ReactivatePermanentRankDTO
    {
        public string UserName{ get; set; }
        public Guid PermanentPurchaseId { get; set; }
    }
}
