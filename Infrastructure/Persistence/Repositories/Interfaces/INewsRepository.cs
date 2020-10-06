using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface INewsRepository : IAsyncRepository<News>
    {
        Task<News> GetLatestNewsAsync();
    }
}
