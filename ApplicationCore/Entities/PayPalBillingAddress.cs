using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("paypalbillingaddress")]
    public class PayPalBillingAddress : BaseEntity
    {
        public string City { get; set; }

        public string Country { get; set; }

        public int Zip { get; set; }

        public string Region { get; set; }

        public string Street { get; set; }

        public Guid PayPalOrderId { get; set; }

        public virtual PayPalOrder PayPalOrder { get; set; }
    }
}
