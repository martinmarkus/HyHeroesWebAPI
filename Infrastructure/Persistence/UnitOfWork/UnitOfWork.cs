﻿using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
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


        public UnitOfWork(
            HyHeroesDbContext context,
            IUserRepository userRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IProductRepository productRepository,
            IPurchaseStateRepository purchaseStateRepository,
            IGameServerRepository gameServerRepository)
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));
            UserRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            PurchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            ProductRepository = productRepository ?? throw new ArgumentException(nameof(context));
            PurchaseStateRepository = purchaseStateRepository ?? throw new ArgumentException(nameof(purchaseStateRepository));
            GameServerRepository = gameServerRepository ?? throw new ArgumentException(nameof(gameServerRepository));
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
