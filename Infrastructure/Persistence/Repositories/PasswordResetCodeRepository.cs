using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PasswordResetCodeRepository : AsyncRepository<PasswordResetCode>, IPasswordResetCodeRepository
    {
        public PasswordResetCodeRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PasswordResetCode> GetByUnusedCodeAsync(Guid resetCode) =>
            await _dbContext.PasswordResetCodes
            .Include(code => code.User)
            .Where(code => code.IsActive
            && code.Code == resetCode
            && code.IsUsed == false)
            .FirstOrDefaultAsync();

        public async Task<PasswordResetCode> GetUserCodeFromLastHourAsync(Guid userId) =>
            await _dbContext.PasswordResetCodes
                .Include(code => code.User)
                .Where(code => code.IsActive
                    && code.User.Id == userId
                    && code.CreationDate.AddHours(1) > DateTime.Now)
                .FirstOrDefaultAsync();
    }
}
