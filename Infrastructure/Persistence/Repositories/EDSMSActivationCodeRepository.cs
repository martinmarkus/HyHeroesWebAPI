using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class EDSMSActivationCodeRepository : AsyncRepository<EDSMSActivationCode>, IEDSMSActivationCodeRepository
    {
        public EDSMSActivationCodeRepository(HyHeroesDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<EDSMSActivationCode> GetUnusedCodeByCodeValueAsync(string activationCode) =>
            await _dbContext.EDSMSActivationCodes
            .Where(code => code.IsActive
            && !code.IsUsed
            && code.Code.Equals(activationCode, System.StringComparison.OrdinalIgnoreCase))
            .FirstOrDefaultAsync();

        public async Task<IList<EDSMSActivationCode>> GetAllUnusedCodesAsync() =>
            await _dbContext.EDSMSActivationCodes
            .Where(code => code.IsActive
            && !code.IsUsed)
            .ToListAsync();
    }
}
