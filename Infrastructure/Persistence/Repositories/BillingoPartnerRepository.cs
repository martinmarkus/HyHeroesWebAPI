using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoPartnerRepository : AsyncRepository<BillingoPartner>, IBillingoPartnerRepository
    {
        public BillingoPartnerRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<BillingoPartner> GetByUserIdAsync(Guid userId) =>
            await _dbContext.BillingoPartners
                .Include(partner => partner.BillingoBillingAddress)
                .Where(partner => partner.IsActive && partner.UserId == userId)
                .FirstOrDefaultAsync();
    }
}
