using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class EmailVerificationCodeRepository : AsyncRepository<EmailVerificationCode>, IEmailVerificationCodeRepository
    {
        public EmailVerificationCodeRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> UnusedCodesCountAsync(string userName) =>
            await _dbContext.EmailVerificationCodes
                .Include(code => code.User)
                .Where(code => code.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                   && code.IsActive && !code.IsActivated
                   && code.CreationDate.AddMinutes(60) > DateTime.Now)
                .CountAsync();


            public async Task<bool> IsCodeValidAsync(Guid activationCode) =>
            await _dbContext.EmailVerificationCodes
                .Where(code => code.ActivationCode == activationCode
                    && code.IsActive
                    && !code.IsActivated)
                .AnyAsync();

        public async Task UpdateCodeStateAsync(Guid activationCode)
        {
            var code = await _dbContext.EmailVerificationCodes
                .Include(code => code.User)
                .Where(code => code.ActivationCode == activationCode
                    && code.IsActive
                    && !code.IsActivated)
                .FirstOrDefaultAsync();

            if (code == null)
            {
                throw new EmailVerificationCodeException("not found");
            }

            var user = await _dbContext.Users
                .FindAsync(code.User.Id);

            if (user != null && user.IsActive)
            {
                user.Email = code.EmailToVerify;

                _dbContext.Users.Update(user);
                await SaveChangesAsync();
            }

            code.IsActivated = true;
            code.ActivationTimeStamp = DateTime.Now;

            await base.UpdateAsync(code);
        }
    }
}
