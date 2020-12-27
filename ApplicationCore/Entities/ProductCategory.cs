using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class ProductCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        
        public int Priority { get; set; }

        public bool IsUsed { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
