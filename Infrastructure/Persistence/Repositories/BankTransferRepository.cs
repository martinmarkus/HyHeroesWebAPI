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
    public class BankTransferRepository : AsyncRepository<BankTransfer>, IBankTransferRepository
    {
        public BankTransferRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<BankTransfer>> GetTransfersByUserIdAsync(Guid id) =>
            await _dbContext.BankTransfers
                .Where(transfer => transfer.IsActive && !transfer.IsActivated
                    && transfer.UserId == id)
                .OrderByDescending(transfer => transfer.CreationDate)
                .ToListAsync();

        public async Task<BankTransfer> GetByTransferCodeAsync(Guid id, string transferCode) =>
            await _dbContext.BankTransfers
                .Include(transfer => transfer.User)
                .Include(transfer => transfer.BankTransferBillingAddress)
                .Where(transfer => transfer.IsActive && !transfer.IsActivated
                    && transfer.UserId == id
                    && transfer.TransferCode.Equals(transferCode, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(transfer => transfer.CreationDate)
                .FirstOrDefaultAsync();

        public async Task<IList<BankTransfer>> GetAllbyUserNameOrTransferCodeAsync(string userNameOrTransferCode) =>
            await _dbContext.BankTransfers
                .Include(transfer => transfer.User)
                .Include(transfer => transfer.BankTransferBillingAddress)
                .Where(transfer => transfer.IsActive
                    && (transfer.User.UserName.Equals(userNameOrTransferCode, StringComparison.OrdinalIgnoreCase)
                        || transfer.TransferCode.Equals(userNameOrTransferCode, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(transfer => !transfer.IsActivated)
                .ThenByDescending(transfer => transfer.CreationDate)
                .ToListAsync();
    }
}
