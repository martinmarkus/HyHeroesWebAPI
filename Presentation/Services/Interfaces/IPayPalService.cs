using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalService
    {
        Task<bool> ProcessIPNAsync(PayPalIPNDTO payPalIPNDTO);
    }
}
