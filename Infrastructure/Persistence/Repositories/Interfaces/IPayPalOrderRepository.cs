using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPayPalOrderRepository : IAsyncRepository<PayPalOrder>
    {
        Task<PayPalOrder> GetUnfinisheByOrderIdAsync(string captureId);

        Task<PayPalOrder> GetFinisheByOrderIdAsync(string captureId);
    }
}
