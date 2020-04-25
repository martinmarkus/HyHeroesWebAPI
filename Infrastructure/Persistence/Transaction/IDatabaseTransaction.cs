using System;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Transaction
{
    public interface IDatabaseTransaction : IDisposable
    {
        void Commit();

        void Rollback();
    }
}
