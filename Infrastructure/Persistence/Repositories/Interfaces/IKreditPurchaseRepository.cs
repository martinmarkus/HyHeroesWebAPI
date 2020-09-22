using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IKreditPurchaseRepository : IAsyncRepository<KreditPurchase>
    {
        Task<IList<KreditPurchase>> GetAllEDSMSKreditPurchasesAsync();

        Task<IList<KreditPurchase>> GetAllBarionPurchasesesAsync();

        Task<IList<KreditPurchase>> GetAllPayPalPurchasesAsync();
    }
}
