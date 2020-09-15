using HyHeroesWebAPI.ApplicationCore.DataObjects;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface IHttpRequestService
    {
        Task<HttpResponseData> GetJsonResponseAsync(HttpRequestData httpRequestData);
    }
}
