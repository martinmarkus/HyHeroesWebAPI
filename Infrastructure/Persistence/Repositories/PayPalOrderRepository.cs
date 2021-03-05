using System.Linq;
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

        public async Task<PayPalOrder> GetByOrderIdAsync(string captureId) =>
            await _dbContext.PayPalOrders.FirstOrDefaultAsync(order =>
                order.IsActive && order.OrderId == captureId);
    }
}
