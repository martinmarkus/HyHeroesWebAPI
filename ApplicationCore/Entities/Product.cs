using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
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

        //[Required]
        public Guid? ProductCategoryId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
