using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("products")]
    public class Product : BaseEntity
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public int PricePerMonth { get; set; }

        [Required]
        public int PermanentPrice { get; set; }

        public string ImageUrl { get; set; }

        #nullable enable
        public string? Description { get; set; }

        public string? InGameActivatorCommand { get; set; }

        public string? InGameDeactivatorCommand { get; set; }

        public string? OneTimeCommand { get; set; }
        #nullable disable

        public bool IsRank { get; set; }

        public Guid? GameServerId { get; set; }

        public virtual GameServer GameServer { get; set; }

        public Guid? ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ICollection<PurchasedProduct> PurchasedProducts { get; set; }
    }
}
