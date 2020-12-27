using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class EDSMSActivationCode : RandomCodeContainer
    {
        public string SenderPhoneNumber { get; set; }

        public int KreditValue { get; set; }

        public bool IsUsed { get; set; }

        public bool  IsGeneratedByAdmin { get; set; }

        public Guid KreditPurchaseId { get; set; }

        public virtual KreditPurchase KreditPurchase { get; set; }
    }
}
