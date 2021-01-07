using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IKreditPurchaseRepository : IAsyncRepository<KreditPurchase>
    {
        Task<IList<KreditPurchase>> GetAllByPaymentTypeAsync(PaymentType paymentType);
    }
}
