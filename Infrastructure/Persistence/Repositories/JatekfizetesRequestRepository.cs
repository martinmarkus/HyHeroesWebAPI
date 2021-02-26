using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class JatekfizetesRequestRepository : AsyncRepository<JatekfizetesRequest>, IJatekfizetesRequestRepository
    {
        public JatekfizetesRequestRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> IsClientIPOnCooldownAsync(string clientIP) =>
            (await _dbContext.JatekfizetesRequests
                .CountAsync(request => request.IsActive 
                    && request.CallDate >= DateTime.Now.AddSeconds(-60)))
                >= 3;
    }
}
