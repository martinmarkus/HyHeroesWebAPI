using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BlacklistedIPRepository : AsyncRepository<BlacklistedIP>, IBlacklistedIPRepository
    {
        public BlacklistedIPRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<BlacklistedIP> AddAsync(BlacklistedIP entity)
        {
            if (entity == null || string.IsNullOrEmpty(entity.IP))
            {
                return null;
            }

            var existingBlock = await _dbContext.BlacklistedIPs
                .Where(ip => ip.IsActive && ip.IP.Equals(entity.IP, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync();

            if (existingBlock != null)
            {
                if (!existingBlock.IsIPBanned)
                {
                    existingBlock.IsIPBanned = true;
                    existingBlock.IP = entity.IP;
                    existingBlock.BanDate = entity.BanDate;

                    await UpdateAsync(existingBlock);
                }
            }
            else
            {
                return await base.AddAsync(entity);
            }

            return null;
        }

        public async Task<bool> CheckIfExistsByIPAsync(string iP) =>
            await _dbContext.BlacklistedIPs
                .Where(ip => ip.IsActive && ip.IsIPBanned
                    && ip.IP.Equals(iP, StringComparison.OrdinalIgnoreCase))
                .AnyAsync();

        public async Task UnbanIpAsync(string IP)
        {
            if (string.IsNullOrEmpty(IP))
            {
                return;
            }

            var existingBlock = await _dbContext.BlacklistedIPs
                .Where(ip => ip.IsActive && ip.IP.Equals(IP, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync();

            if (existingBlock != null)
            {
                existingBlock.IsIPBanned = false;
                await UpdateAsync(existingBlock);
            }
        }
    }
}
