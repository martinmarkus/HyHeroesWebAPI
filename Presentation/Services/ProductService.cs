using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductMapper _productMapper;

        public ProductService(
            IProductRepository productRepository,
            IProductMapper productMapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _productMapper = productMapper ?? throw new ArgumentNullException(nameof(productMapper));
        }

        public async Task<IList<ProductDTO>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();

            return _productMapper.MapAll(products);
        }
    }
}
