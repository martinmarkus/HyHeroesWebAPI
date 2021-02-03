using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IBarionPaymentService
    {
        Task<InitializedBarionTransactionDTO> InitializeTransactionAsync(string userName, BarionPaymentTransactionDTO paymentTransactionDTO);

        Task ProcessBarionCallbackAsync(BarionCallbackDTO barionCallbackDTO);

        BarionPurchaseTypeListDTO GetBarionPurchaseTypes();
    }
}
