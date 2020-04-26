using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class UserRepository : AsyncRepository<User>, IUserRepository
    {
        public UserRepository(HyHeroesDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmailOrUserNameAndPasswordAsync(string emailOrUserName, string passwordHash)
        {
            var userByEmail = await _dbContext.Users
                .Where(user => user.Email.Equals(emailOrUserName, StringComparison.OrdinalIgnoreCase)
                && user.PasswordHash.Equals(passwordHash)
                && user.IsActive)
                .Include(user => user.Role)
                .FirstOrDefaultAsync();

            if (userByEmail == null)
            {
                return await  _dbContext.Users
                    .Where(user => user.UserName.Equals(emailOrUserName, StringComparison.Ordinal)
                    && user.PasswordHash.Equals(passwordHash)
                    && user.IsActive)
                    .Include(user => user.Role)
                    .FirstOrDefaultAsync();
            }

            return userByEmail;
        }

        public async Task<User> GetByEmailOrUserNameAsync(string emailOrUserName)
        {
            var userByEmail = await _dbContext.Users
                .Where(user => user.Email.Equals(emailOrUserName, StringComparison.OrdinalIgnoreCase)
                && user.IsActive)
                .Include(user => user.Role)
                .FirstOrDefaultAsync();

            if (userByEmail == null)
            {
                return await _dbContext.Users
                    .Where(user => user.UserName.Equals(emailOrUserName, StringComparison.Ordinal)
                    && user.IsActive)
                    .Include(user => user.Role)
                    .FirstOrDefaultAsync();
            }

            return userByEmail;
        }

        public async Task<User> GetByEmailAsync(string email) =>
            await _dbContext.Users
               .Include(user => user.Role)
               .Where(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
               && user.IsActive)
               .FirstOrDefaultAsync();

        public async Task<bool> UserAlreadyExistsByNewUserAsync(NewUser newUser)
        {
            var user = await _dbContext.Users
                 .Where(user => (user.Email.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase)
                 || user.UserName.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase))
                 && user.IsActive)
                 .FirstOrDefaultAsync();

            return user != null;
        }

        public async Task<bool> UserExistsByEmailOrUserName(string email, string userName)
        {
            var user = await _dbContext.Users
                .Where(user => (user.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                || user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                && user.IsActive)
                .FirstOrDefaultAsync();

            return user != null;
        }

        public override async Task<User> GetByIdAsync(Guid id) =>
            await _dbContext.Users
             .Include(user => user.Role)
             .Where(entity => entity.Id == id && entity.IsActive)
             .FirstOrDefaultAsync();
    }
}
