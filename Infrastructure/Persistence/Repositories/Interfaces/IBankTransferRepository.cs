using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IBankTransferRepository : IAsyncRepository<BankTransfer>
    {
        Task<IList<BankTransfer>> GetTransfersByUserIdAsync(Guid id);
        
        Task<BankTransfer> GetByTransferCodeAsync(Guid id, string transferCode);
    }
}
