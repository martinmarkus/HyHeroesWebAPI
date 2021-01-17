using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class UserRepository : AsyncRepository<User>, IUserRepository
    {
        public UserRepository(HyHeroesDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmailOrUserNameAndPasswordAsync(string emailOrUserName, string passwordHash)
        {
            var userByEmail = (await GetAllUsersAsync())
                .Where(user => !string.IsNullOrEmpty(user.Email) && 
                user.Email.Equals(emailOrUserName, StringComparison.OrdinalIgnoreCase)
                && user.PasswordHash.Equals(passwordHash))
                .FirstOrDefault();

            if (userByEmail == null)
            {
                return (await GetAllUsersAsync())
                    .Where(user => user.UserName.Equals(emailOrUserName, StringComparison.Ordinal)
                    && user.PasswordHash.Equals(passwordHash))
                    .FirstOrDefault();
            }

            return userByEmail;
        }

        public async Task<User> GetByEmailOrUserNameAsync(string emailOrUserName)
        {
            var userByEmail = (await GetAllUsersAsync())
                .Where(user => !string.IsNullOrEmpty(user.Email) && 
                user.Email.Equals(emailOrUserName, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            if (userByEmail == null)
            {
                return (await GetAllUsersAsync())
                    .Where(user => user.UserName.Equals(emailOrUserName, StringComparison.Ordinal))
                    .FirstOrDefault();
            }

            return userByEmail;
        }

        public async Task<User> GetByEmailAsync(string email) =>
            (await GetAllUsersAsync())
               .Where(user => !string.IsNullOrEmpty(user.Email) &&
               user.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
               .FirstOrDefault();

        public async Task<bool> UserAlreadyExistsByNewUserAsync(NewUser newUser)
        {
            var user = (await GetAllUsersAsync())
                 .Where(user => ((!string.IsNullOrEmpty(user.Email) &&
                 user.Email.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase))
                 || user.UserName.Equals(newUser.UserName, StringComparison.OrdinalIgnoreCase)))
                 .FirstOrDefault();

            return user != null;
        }

        public async Task<bool> UserExistsByEmailAsync(string email)
        {
            var user = (await GetAllUsersAsync())
                .Where(user => (!string.IsNullOrEmpty(user.Email) &&
                    user.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                .FirstOrDefault();

            return user != null;
        }

        public async Task<bool> UserExistsByUserNameAsync(string userName)
        {
            var user = (await GetAllUsersAsync())
                .Where(user => (user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)))
                .FirstOrDefault();

            return user != null;
        }

        public override async Task<User> GetByIdAsync(Guid id) =>
            (await GetAllUsersAsync())
               .Where(entity => entity.Id == id)
               .FirstOrDefault();

        public async Task<User> GetByUserNameAsync(string userName) =>
            (await GetAllUsersAsync())
               .Where(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
               .FirstOrDefault();

        private async Task<IList<User>> GetAllUsersAsync() =>
            await _dbContext.Users
               .Include(user => user.Role)
               .Where(user => user.IsActive)
               .ToListAsync();

        public async Task BanUserAsync(string userName)
        {
            var user = await _dbContext.Users
                .Where(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                && user.IsActive)
                .FirstOrDefaultAsync();

            user.IsBanned = true;

            await base.UpdateAsync(user);
        }

        public async Task<IList<User>> GetAllForToplistAsync() =>
            (await GetAllUsersAsync())
                .OrderByDescending(user => user.HyCoin)
                .Take(500)
                .ToList();

        public async Task<bool> IsEmailRegisteredAsync(string emailToVerify) =>
            await _dbContext.Users
                .Where(user => 
                    !string.IsNullOrEmpty(user.Email)
                    && user.Email.Equals(emailToVerify, StringComparison.OrdinalIgnoreCase))
                .AnyAsync();


        public async Task<bool> IsEmailAlreadyVerifiedAsync(string userName, string emailToVerify) =>
            await _dbContext.Users
                .Where(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                    && !string.IsNullOrEmpty(user.Email))
                .AnyAsync();

        public async Task<bool> SetEmailAsync(string userName, string emailToVerify)
        {
            try
            {
                var user = await _dbContext.Users
                    .Where(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                    && user.IsActive)
                    .FirstOrDefaultAsync();

                user.Email = emailToVerify;

                await base.UpdateAsync(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public async Task<User> GetByPasswordResetCodeIdAsync(Guid resetCodeId) =>
            await _dbContext.Users
                .Include(user => user.PasswordResetCodes)
                .Where(user => user.IsActive && !user.IsBanned 
                    && user.PasswordResetCodes
                        .Where(code => code.IsActive && !code.IsUsed)
                        .Select(code => code.Code)
                        .Contains(resetCodeId))
                .FirstOrDefaultAsync();

        public async Task<int> getCountOfAllAsync() =>
            await _dbContext.Users
                .CountAsync(user => user.IsActive && !user.IsBanned);

        public async Task<ClientIdentity> GetIdentityByTokenValuesAsync(string baseValue, string encryptedValue) =>
              await _dbContext.ClientIdentities
                .Include(identity => identity.User)
                .Where(identity => identity.IsActive
                    && identity.BaseValue.Equals(baseValue, StringComparison.OrdinalIgnoreCase)
                    && identity.ValidatorHash.Equals(encryptedValue, StringComparison.OrdinalIgnoreCase)
                    && identity.ExpirationDate > DateTime.Now)
                .FirstOrDefaultAsync();
    }
}
