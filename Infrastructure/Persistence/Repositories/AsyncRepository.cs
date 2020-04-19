﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public abstract class AsyncRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected HyHeroesDbContext _dbContext;

        public AsyncRepository(HyHeroesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            T existing = await _dbContext.Set<T>()
                .FindAsync(entity.Id);

            if (existing == null)
            {
                var user = await _dbContext.Set<T>()
                    .AddAsync(entity);

                await SaveChanges();

                return user.Entity;
            }

            return default(T);
        }

        public virtual async Task AddRangeAsync(IList<T> entities)
        {
            await _dbContext.Set<T>()
                .AddRangeAsync(entities);

            await SaveChanges();
        }

        public virtual async Task<bool> CheckIfExistsByIdAsync(Guid id)
        {
            var entity = await _dbContext.Set<T>()
                .Where(entity => (entity.Id == id
                    && entity.IsActive))
                .FirstOrDefaultAsync();

            return entity != null;
        }

        public virtual async Task<IList<T>> GetAllAsync() =>
            await _dbContext.Set<T>()
            .Where(entity => entity.IsActive)
            .ToListAsync();

        public virtual async Task<T> GetByIdAsync(Guid id) =>
            await _dbContext.Set<T>()
             .Where(entity => entity.Id == id && entity.IsActive)
             .FirstOrDefaultAsync();

        public virtual async Task RemoveAsync(T entity)
        {
            entity.IsActive = false;

            T existing = _dbContext.Set<T>()
                .Find(entity.Id);

            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(entity);
                await SaveChanges();
            }
        }

        public virtual async Task UpdateAsync(T entity)
        {
            T existing = _dbContext.Set<T>()
                .Find(entity.Id);

            if (existing != null && entity.IsActive)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(entity);
                await SaveChanges();
            }
        }

        private async Task SaveChanges()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
