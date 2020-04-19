using HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class InvoiceIssuerRepository : AsyncRepository<InvoiceIssuer>, IInvoiceIssuerRepository
    {
        public InvoiceIssuerRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
