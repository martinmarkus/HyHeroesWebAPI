using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("edsmspurchases")]
    public class EDSMSPurchase : BaseEntity
    {
        public string ActivationCode { get; set; }

        public Guid KreditPurchaseId { get; set; }

        public virtual KreditPurchase KreditPurchase { get; set; }
    }
}
