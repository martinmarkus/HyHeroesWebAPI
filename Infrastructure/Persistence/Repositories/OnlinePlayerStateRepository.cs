using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Extensions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class OnlinePlayerStateRepository : AsyncRepository<OnlinePlayerState>, IOnlinePlayerStateRepository
    {
        public OnlinePlayerStateRepository(HyHeroesDbContext context) : base(context)
        {
        }

        public async Task<IList<OnlinePlayerStateQueryResult>> GetLastDayDataAsync() =>
            await _dbContext.OnlinePlayerStates
                .Where(state => state.IsActive && state.CreationDate >= DateTime.Now.AddHours(-24))
                .GroupBy(state => state.CreationDate)
                .Select(grp => new OnlinePlayerStateQueryResult
                {
                    HourDate = grp.Key,
                    PlayerCount = Convert.ToInt32(grp.Average(state => state.OnlinePlayerCount))
                })
                .OrderByDescending(state => state.HourDate)
                .ToListAsync();

        public async Task RemoveAllAsync()
        {
            _dbContext.OnlinePlayerStates.Clear();
            await _dbContext.SaveChangesAsync();
        }
    }
}
