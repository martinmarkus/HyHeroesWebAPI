using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IKreditGiftRepository : IAsyncRepository<KreditGift>
    {
        Task<IList<KreditGift>> GetUserKreditGiftingsAsync(Guid id);
    }
}
