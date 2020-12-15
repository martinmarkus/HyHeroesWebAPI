using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<IList<News>> GetLatestNewsAsync(int amount) =>
            await _dbContext.News
                .Include(news => news.PublisherUser)
                .Where(news => news.IsActive)
                .OrderByDescending(news => news.PublishDate)
                .Take(Math.Abs(amount))
                .ToListAsync();
    }
}
