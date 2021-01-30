using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class EDSMSPurchase : BaseEntity
    {
        public string ActivationCode { get; set; }

        public Guid KreditPurchaseId { get; set; }

        public virtual KreditPurchase KreditPurchase { get; set; }
    }
}
