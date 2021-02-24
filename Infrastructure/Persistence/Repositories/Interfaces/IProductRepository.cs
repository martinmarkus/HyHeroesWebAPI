using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<IList<Product>> GetAllNonRanksByCategoryIdAsync(Guid categoryId);
       
        Task<IList<Product>> GetAllRankProductsAsync();
       
        Task<IList<ProductCategory>> GetAllCategoriesAsync();

        Task<IList<Product>> GetTopProductStatsAsync();
    }
}
