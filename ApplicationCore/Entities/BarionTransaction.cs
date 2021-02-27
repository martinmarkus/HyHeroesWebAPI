using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("bariontransactions")]
    public class BarionTransaction : BaseEntity
    {
        public Guid PaymentId { get; set; }

        public bool IsFinished { get; set; } = false;

        public DateTime FinishDate { get; set; }

        public BarionTransactionState State { get; set; } = BarionTransactionState.Started;

        public string GatewayURL { get; set; }

        public double KreditAmount { get; set; }

        public string BillingName { get; set; }

        public string BillingEmail { get; set; }

        public double TotalCost { get; set; }

        public string TaxNumber { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
         
        public virtual BarionBillingAddress BarionBillingAddress { get; set; }
    }
}
