namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal PricePerMonth { get; set; }

        public decimal PermanentPrice { get; set; }

        #nullable enable
        public string? Description { get; set; }

        public string? InGameActivatorCommand { get; set; }

        public string? InGameDeactivatorCommand { get; set; }
        #nullable disable
    }
}
