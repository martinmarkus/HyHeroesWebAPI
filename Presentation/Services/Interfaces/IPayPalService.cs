using HyHeroesWebAPI.Presentation.DTOs;
using System.IO;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalService
    {
        Task<PayPalOrderResponseDTO> CreatePayPalTransactionAsync(string authenticatedUserName);

        void TryVerifyPayment(string bodyJson);
    }
}
