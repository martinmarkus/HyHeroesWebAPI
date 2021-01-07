using Microsoft.EntityFrameworkCore;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Extensions
{
    public static class DbSetExtensions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
