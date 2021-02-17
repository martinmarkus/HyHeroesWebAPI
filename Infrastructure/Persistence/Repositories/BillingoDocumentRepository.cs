using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoDocumentRepository : AsyncRepository<BillingoDocument>, IBillingoDocumentRepository
    {
        public BillingoDocumentRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
