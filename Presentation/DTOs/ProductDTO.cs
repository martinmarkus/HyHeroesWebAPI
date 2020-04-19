namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        #nullable enable
        public string? Description { get; set; }

        public string? InGameActivatorCommand { get; set; }

        public string? InGameDeactivatorCommand { get; set; }
        #nullable disable
    }
}
