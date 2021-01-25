using HyHeroesWebAPI.Presentation.DTOs;
using System.IO;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalService
    {
        Task<PayPalTransactionDTO> CreatePayPalTransaction(string authenticatedUserName);

        Task<bool> ProcessIPNStreamAsync(Stream ipnStream);
    }
}
