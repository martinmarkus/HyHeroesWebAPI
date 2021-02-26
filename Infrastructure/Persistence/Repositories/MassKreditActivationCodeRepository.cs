using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class MassKreditActivationCodeRepository : AsyncRepository<MassKreditActivationCode>, IMassKreditActivationCodeRepository
    {
        public MassKreditActivationCodeRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<MassKreditActivationCode>> GetAllActiveCodesAsync() =>
            await _dbContext.MassKreditActivationCodes
                .Include(code => code.MassKreditUserActivations)
                .Where(code => code.IsActive
                    && code.StartDate < DateTime.Now
                    && code.ExpirationDate > DateTime.Now)
                .OrderByDescending(code => code.CreationDate)
                .ToListAsync();

        public async Task<MassKreditActivationCode> GetByKreditCodeAsync(string kreditCode) =>
            await _dbContext.MassKreditActivationCodes
                .Include(code => code.MassKreditUserActivations)
                .Where(code => code.IsActive
                    && code.Code.Equals(kreditCode, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync();

        public async Task RemoveByKreditCodeAsync(string removeCode)
        {
            var existingCode = await _dbContext.MassKreditActivationCodes
                .Where(code => code.IsActive
                    && code.Code.Equals(removeCode, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync();

            if (existingCode != null)
            {
                await base.RemoveAsync(existingCode.Id);
            }
        }
    }
}
