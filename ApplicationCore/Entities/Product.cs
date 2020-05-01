using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class Product : BaseEntity
    {

        [Required]
        public string Name { get; set; }


        [Required]
        public decimal PricePerMonth { get; set; }


        [Required]
        public decimal PermanentPrice { get; set; }

        #nullable enable
        public string? Description { get; set; }

        public string? InGameActivatorCommand { get; set; }

        public string? InGameDeactivatorCommand { get; set; }
        #nullable disable
    }
}
