using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingTransactionRepository : AsyncRepository<BillingTransaction>, IBillingTransactionRepository
    {
        public BillingTransactionRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
