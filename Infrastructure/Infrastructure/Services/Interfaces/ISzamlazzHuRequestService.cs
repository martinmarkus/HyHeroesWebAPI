using System.Net;
using System.Net.Http;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces
{
    public interface ISzamlazzHuRequestService
    {
        void InitHttpClientHandler(CookieContainer cookieContainer);
        HttpResponseMessage SendRequest(ByteArrayContent content, string filename);
    }
}
