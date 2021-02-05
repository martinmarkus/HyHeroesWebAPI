using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IBankTransferService
    {
        Task<StartedBankTransferDTO> StartManualKreditPurchaseAsync(
            BankTransferPurchaseDTO customKreditPurchaseDTO,
            string userName);
        
        Task ApplyBankTransferAsync(ApplyBankTransferDTO applyBankTransferDTO);
    }
}
