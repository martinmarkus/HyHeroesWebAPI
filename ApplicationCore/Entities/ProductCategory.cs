using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class ProductCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        
        public int Priority { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
