using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BarionTransactionStart : BaseEntity
    {
        public string PaymentId { get; set; }

        public bool IsFinished { get; set; } = false;

        public DateTime FinishDate { get; set; }

        public BarionTransactionState State { get; set; } = BarionTransactionState.Started;

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
