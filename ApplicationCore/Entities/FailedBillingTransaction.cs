using HyHeroesWebAPI.ApplicationCore.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class FailedBillingTransaction : BaseEntity
    {
        public DateTime FailDate { get; set; }

        public int KreditAmount { get; set; }

        public int CurrencyValue { get; set; }

        public string ErrorMessage{ get; set; }

        public PaymentType PaymentType { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

    }
}
