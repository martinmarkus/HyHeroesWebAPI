using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IHttpCallCounterService
    {
        Task<bool> AddCallTryAsync(string IPValue);
        void StartLoginTriesValidation();
    }
}
