using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        Task<IList<Product>> GetAllProducts();
    }
}
