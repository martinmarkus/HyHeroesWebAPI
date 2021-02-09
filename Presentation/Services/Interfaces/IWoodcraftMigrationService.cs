using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IWoodcraftMigrationService
    {
        Task ValidateWoodcraftUserAsync(WoodcraftUserDTO woodcraftUserDTO, string IP);

        Task ValidateWoodcraftUserRangeAsync(WoodcraftUserListDTO woodcraftUserListDTO, string IP);
    }
}
