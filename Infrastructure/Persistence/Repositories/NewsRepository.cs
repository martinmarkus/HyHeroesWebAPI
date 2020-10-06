using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class NewsRepository : AsyncRepository<News>, INewsRepository
    {
        public NewsRepository(HyHeroesDbContext dbContext) 
            : base(dbContext)
        {
        }

        public async Task<News> GetLatestNewsAsync() =>
            await _dbContext.News
            .Where(news => news.IsActive)
            .OrderByDescending(news => news.PublishDate)
            .FirstOrDefaultAsync();
    }
}
