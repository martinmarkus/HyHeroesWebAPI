using HyHeroesWebAPI.Infrastructure.Infrastructure.DataObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IBillService
    {
        Task<BillCreationResponse> CreateBill(CreateBillDTO createBillDTO);
    }
}
