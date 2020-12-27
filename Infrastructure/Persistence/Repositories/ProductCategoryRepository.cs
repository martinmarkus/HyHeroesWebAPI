using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class ProductCategoryRepository : AsyncRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ProductCategory> GetCategoryByIdAsync(Guid categoryId) =>
            await _dbContext.ProductCategories
                .Where(cat => cat.IsActive
                    && cat.Id == categoryId)
                .FirstOrDefaultAsync();
    }
}
