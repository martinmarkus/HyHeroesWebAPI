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
    public class NotificationRepository : AsyncRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<Notification>> GetNotOpenedsByUserIdAsync(Guid userId) =>
            await _dbContext.Notifications
                .Include(notification => notification.User)
                .Where(notification => notification.IsActive 
                    && notification.UserId == userId
                    && !notification.IsOpened)
                .OrderByDescending(notification => notification.CreationDate)
                .ToListAsync();

        public async Task<IList<Notification>> GetLastOpenedsByUserIdAsync(Guid userId) =>
            await _dbContext.Notifications
                .Include(notification => notification.User)
                .Where(notification => notification.IsActive
                    && notification.UserId == userId
                    && notification.IsOpened)
                .OrderByDescending(notification => notification.CreationDate)
                .Take(10)
                .ToListAsync();
    }
}
