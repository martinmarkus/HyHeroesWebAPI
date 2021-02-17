using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IBillingoBankAccountRepository : IAsyncRepository<BillingoBankAccount>
    {
        Task<BillingoBankAccount> GetSellerBankAccountAsync();
    }
}
