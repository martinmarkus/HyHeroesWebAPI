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
    public class KreditGiftRepository : AsyncRepository<KreditGift>, IKreditGiftRepository
    {
        public KreditGiftRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<KreditGift>> GetUserKreditGiftingsAsync(Guid id) =>
            await _dbContext.KreditGifts
                .Include(gift => gift.SenderUser)
                .Include(gift => gift.ReceiverUser)
                .Where(gift => gift.IsActive
                    && gift.SenderUserId == id)
                .ToListAsync();
    }
}
