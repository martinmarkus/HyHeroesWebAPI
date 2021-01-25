using HyHeroesWebAPI.ApplicationCore.Enums;
using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BarionTransaction : BaseEntity
    {
        public Guid PaymentId { get; set; }

        public bool IsFinished { get; set; } = false;

        public DateTime FinishDate { get; set; }

        public BarionTransactionState State { get; set; } = BarionTransactionState.Started;

        public double KreditAmount { get; set; }

        public double TotalCost { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public virtual BarionBillingAddress BarionBillingAddress { get; set; }
    }
}
