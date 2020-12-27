using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IProductCategoryRepository : IAsyncRepository<ProductCategory>
    {
        Task<ProductCategory> GetCategoryByIdAsync(Guid categoryId);
    }
}
