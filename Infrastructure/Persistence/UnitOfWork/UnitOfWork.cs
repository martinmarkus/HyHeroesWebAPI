using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Transaction;
using System;

namespace HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HyHeroesDbContext _dbContext;

        public IUserRepository UserRepository { get; private set; }

        public IPurchasedProductRepository PurchasedProductRepository { get; private set; }

        public IProductRepository ProductRepository { get; private set; }

        public IPurchaseStateRepository PurchaseStateRepository { get; private set; }

        public IGameServerRepository GameServerRepository { get; private set; }

        public IBankTransferRepository BankTransferRepository { get; private set; }

        public IKreditPurchaseRepository KreditPurchaseRepository { get; private set; }

        public IBillingTransactionRepository BillingTransactionRepository { get; private set; }

        public IBarionTransactionRepository BarionTransactionRepository { get; private set; }

        public IKreditGiftRepository KreditGiftRepository { get; private set; }

        public IPayPalOrderRepository PayPalOrderRepository { get; private set; }

        public UnitOfWork(
            HyHeroesDbContext context,
            IUserRepository userRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IProductRepository productRepository,
            IPurchaseStateRepository purchaseStateRepository,
            IGameServerRepository gameServerRepository,
            IBankTransferRepository bankTransferRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IBillingTransactionRepository billingTransactionRepository,
            IBarionTransactionRepository barionTransactionRepository,
            IKreditGiftRepository kreditGiftRepository,
            IPayPalOrderRepository payPalOrderRepository)
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));

            UserRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            PurchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            ProductRepository = productRepository ?? throw new ArgumentException(nameof(productRepository));
            PurchaseStateRepository = purchaseStateRepository ?? throw new ArgumentException(nameof(purchaseStateRepository));
            GameServerRepository = gameServerRepository ?? throw new ArgumentException(nameof(gameServerRepository));
            BankTransferRepository = bankTransferRepository ?? throw new ArgumentException(nameof(bankTransferRepository));
            KreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            BillingTransactionRepository = billingTransactionRepository ?? throw new ArgumentException(nameof(billingTransactionRepository));
            BarionTransactionRepository = barionTransactionRepository ?? throw new ArgumentException(nameof(barionTransactionRepository));
            KreditGiftRepository = kreditGiftRepository ?? throw new ArgumentException(nameof(kreditGiftRepository));
            PayPalOrderRepository = payPalOrderRepository ?? throw new ArgumentException(nameof(payPalOrderRepository));
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
