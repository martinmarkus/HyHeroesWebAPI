using HyHeroesWebAPI.Presentation.DTOs;
using System.IO;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalService
    {
        Task<PayPalOrderResponseDTO> CreatePayPalTransaction(string authenticatedUserName);

        Task<bool> ProcessIPNStreamAsync(Stream ipnStream);

        Task VerifyTask(PayPalIPNContextDTO ipnContext);
    }
}
