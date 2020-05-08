using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Transaction;

namespace HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HyHeroesDbContext _dbContext;
        public IUserRepository UserRepository { get; private set; }
        public IPurchasedProductRepository PurchasedProductRepository { get; private set; }
        public IProductRepository ProductRepository { get; private set; }

        public UnitOfWork(
            HyHeroesDbContext context,
            IUserRepository userRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IProductRepository productRepository)
        {
            _dbContext = context;
            UserRepository = userRepository;
            PurchasedProductRepository = purchasedProductRepository;
            ProductRepository = productRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IDatabaseTransaction BeginTransaction()
        {
            return new DatabaseTransaction(_dbContext);
        }
    }
}
