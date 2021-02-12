using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IBankTransferService
    {
        Task<StartedBankTransferDTO> StartBankTransferKreditPurchaseAsync(
            BankTransferPurchaseDTO customKreditPurchaseDTO,
            string userName);

        Task<BankTransferDTO> ApplyBankTransferAsync(string transferCode);

        BankTransferTypeListDTO GetBankTransferPurchaseTypes();

        Task<BankTransferListDTO> GetBankTransferTransactionsAsync(string userNameOrTransferCode);
    }
}
