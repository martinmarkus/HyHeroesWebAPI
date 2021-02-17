using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoDocumentSettingsRepository : AsyncRepository<BillingoDocumentSettings>, IBillingoDocumentSettingsRepository
    {
        public BillingoDocumentSettingsRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
