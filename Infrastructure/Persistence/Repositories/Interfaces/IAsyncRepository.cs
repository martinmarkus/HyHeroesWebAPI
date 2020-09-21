using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IList<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task AddRangeAsync(IList<T> entity);

        Task UpdateAsync(T entity);

        Task RemoveAsync(Guid productId);

        Task<bool> CheckIfExistsByIdAsync(Guid id);

        Task UpdateWithoutSaveAsync(T entity);

        Task<T> AddWithoutSaveAsync(T entity);

        Task SaveChangesAsync();
    }
}
