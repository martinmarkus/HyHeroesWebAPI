using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("paypaltransactionrequests")]
    public class PayPalTransactionRequest : BaseEntity
    {
        public bool IsRequestProcessed { get; set; }

        public Guid RequesterUserId { get; set; }

        public User RequesterUser { get; set; }
    }
}
