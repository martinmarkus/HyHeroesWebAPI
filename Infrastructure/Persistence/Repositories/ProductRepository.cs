using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IList<Product>> GetAllProducts() =>
            await _dbContext.Products
                .Where(product => product.IsActive)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllUnverifiedProducts() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.IsVerified
                && purchasedProduct.IsActive)
                .ToListAsync();
    }
}
