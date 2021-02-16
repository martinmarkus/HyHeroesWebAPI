using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Transaction;
using System;

namespace HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDatabaseTransaction BeginTransaction();

        IUserRepository UserRepository { get; }

        IPurchasedProductRepository PurchasedProductRepository { get; }

        IProductRepository ProductRepository { get; }

        IPurchaseStateRepository PurchaseStateRepository { get; }

        IGameServerRepository GameServerRepository { get; }

        IBankTransferRepository BankTransferRepository { get; }

        IKreditPurchaseRepository KreditPurchaseRepository { get; }

        IBillingTransactionRepository BillingTransactionRepository { get; }

        IBarionTransactionRepository BarionTransactionRepository { get; }

        IKreditGiftRepository KreditGiftRepository { get; }
    }
}
