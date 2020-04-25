using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Transaction
{
    public class DatabaseTransaction : IDatabaseTransaction
    {
        private IDbContextTransaction _transaction;

        public DatabaseTransaction(HyHeroesDbContext context)
        {
            _transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _transaction.Dispose();
        }
    }
}
