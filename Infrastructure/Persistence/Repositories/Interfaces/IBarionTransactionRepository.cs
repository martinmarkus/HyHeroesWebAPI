using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IBarionTransactionRepository : IAsyncRepository<BarionTransaction>
    {
        Task<BarionTransaction> GetByBarionPaymentIdAsync(Guid paymentId);
        
        Task<BarionTransaction> GetStartedByBarionPaymentIdAsync(Guid paymentId);
    }
}
