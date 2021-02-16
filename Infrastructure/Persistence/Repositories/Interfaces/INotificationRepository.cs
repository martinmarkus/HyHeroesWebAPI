using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface INotificationRepository : IAsyncRepository<Notification>
    {
        Task<IList<Notification>> GetNotOpenedsByUserIdAsync(Guid userId);

        Task<IList<Notification>> GetLastOpenedsByUserIdAsync(Guid userId);
    }
}
