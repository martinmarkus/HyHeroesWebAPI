using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : AsyncRepository<Product>, IProductRepository
    {
        public ProductRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<Product>> GetAllProductsAsync() =>
            await _dbContext.Products
                .Where(product => product.IsActive)
                .OrderBy(product => product.PricePerMonth)
                .OrderBy(product => product.PermanentPrice)
                .ToListAsync();

        public async Task<IList<Product>> GetAllByCategoryIdAsync(Guid categoryId) =>
            await _dbContext.Products
                .Where(product => product.IsActive
                    && product.ProductCategoryId == categoryId)
                .ToListAsync();

        public async Task<IList<ProductCategory>> GetAllCategoriesAsync() =>
            await _dbContext.ProductCategories
                .Where(cat => cat.IsActive)
                .ToListAsync();

        public async Task<IList<Product>> GetTopProductStatsAsync() =>
            await _dbContext.Products
                .Include(product => product.PurchasedProducts)
                .Where(product => product.IsActive 
                    && product.PurchasedProducts != null
                    && product.PurchasedProducts
                        .Where(purchase => purchase.IsActive).Any())
                .OrderByDescending(product => product.PurchasedProducts.Count)
                .Take(10)
                .ToListAsync();
    }
}
