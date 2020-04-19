using HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class InvoiceRepository : AsyncRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
