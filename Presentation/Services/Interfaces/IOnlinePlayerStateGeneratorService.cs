using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IOnlinePlayerStateGeneratorService
    {
        Task GenerateMockPlayerStateDataAsync();
    }
}
