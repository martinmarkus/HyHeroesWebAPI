using System.Net.Http;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Facades.Interfaces
{
    public interface IXmlSerializerFacade
    {
        ByteArrayContent SerializeToByteArray<T>(T obj) where T : class, new();

        string SerializeToString<T>(T obj) where T : class, new();
    }
}
