using System;
using System.Collections.Generic;
using System.Text;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PayPalLinkRepository : AsyncRepository<PayPalLink>, IPayPalLinkRepository
    {
        public PayPalLinkRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
