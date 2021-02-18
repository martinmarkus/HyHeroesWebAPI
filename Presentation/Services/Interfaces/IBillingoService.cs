using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IBillingoService
    {
        Task CreateBillAsync(CreateBillingoBillDTO dto);
    }
}
