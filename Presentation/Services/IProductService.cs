using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public interface IProductService
    {
        Task<IList<ProductDTO>> GetAllProducts();
        Task<IList<PurchasedProductDTO>> GetAllUnverifiedProducts();
    }
}