using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("productcategories")]
    public class ProductCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        
        public int Priority { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
