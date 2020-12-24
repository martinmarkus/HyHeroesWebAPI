using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class MassKreditUserActivationRepository : AsyncRepository<MassKreditUserActivation>, IMassKreditUserActivationRepository
    {
        public MassKreditUserActivationRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<MassKreditUserActivation> GetByUserNameAndMassKreditIdAsync(string userName, Guid massKreditId) =>
            await _dbContext.MassKreditUserActivations
                .Include(activation => activation.User)
                .Include(activation => activation.MassKreditActivationCode)
                .Where(activation => activation.IsActive
                    && activation.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                    && activation.MassKreditActivationCode.Id == massKreditId)
                .FirstOrDefaultAsync();
    }
}
