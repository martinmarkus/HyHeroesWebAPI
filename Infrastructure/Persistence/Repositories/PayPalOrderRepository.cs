using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PayPalOrderRepository : AsyncRepository<PayPalOrder>, IPayPalOrderRepository
    {
        public PayPalOrderRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PayPalOrder> GetFinisheByOrderIdAsync(string captureId) =>
            await _dbContext.PayPalOrders
                .Include(order => order.PayPalBillingAddress)
                .FirstOrDefaultAsync(order => order.IsActive
                    && order.OrderId == captureId
                    && order.IsFinished);

        public async Task<PayPalOrder> GetUnfinisheByOrderIdAsync(string captureId) =>
            await _dbContext.PayPalOrders
                .Include(order => order.PayPalBillingAddress)
                .FirstOrDefaultAsync(order => order.IsActive 
                    && order.OrderId == captureId
                    && !order.IsFinished);
    }
}
