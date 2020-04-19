using HyHeroesWebAPI.ApplicationCore.Entities.InvoiceData;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class InvoiceRequesterRepository : AsyncRepository<InvoiceRequester>, IInvoiceRequesterRepository
    {
        public InvoiceRequesterRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
