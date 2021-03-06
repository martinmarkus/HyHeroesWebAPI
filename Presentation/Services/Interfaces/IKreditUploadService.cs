using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IKreditUploadService
    {
        Task<KreditUploadDTO> GetKreditUploadDataAsync(string v);
    }
}
