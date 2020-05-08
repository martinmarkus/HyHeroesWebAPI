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
                .ToListAsync();

        public async Task<Product> GetIfRankAsync(Guid productId) =>
            await _dbContext.Products
                .Where(product => product.Id == productId
                && product.IsRank
                && product.IsActive)
                .OrderBy(product => product.PricePerMonth)
                .FirstOrDefaultAsync();
    }
}
