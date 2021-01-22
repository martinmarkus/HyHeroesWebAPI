using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IHttpCallCounterService
    {
        Task<bool> AddCallTryAsync(string IPValue);
    }
}
