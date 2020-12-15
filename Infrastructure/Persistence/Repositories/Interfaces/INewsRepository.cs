using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface INewsRepository : IAsyncRepository<News>
    {
        Task<IList<News>> GetLatestNewsAsync(int amount);
    }
}
