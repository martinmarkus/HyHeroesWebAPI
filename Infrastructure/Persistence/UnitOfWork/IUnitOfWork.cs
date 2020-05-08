using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Transaction;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IDatabaseTransaction BeginTransaction();
        IUserRepository UserRepository { get; }
        IPurchasedProductRepository PurchasedProductRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}
