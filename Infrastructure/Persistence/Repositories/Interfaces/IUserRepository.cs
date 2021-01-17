using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUserNameAsync(string userName);

        Task<User> GetByEmailOrUserNameAndPasswordAsync(string emailOrUserName, string password);

        Task<bool> UserAlreadyExistsByNewUserAsync(NewUser newUser);

        Task<bool> UserExistsByEmailAsync(string email);
        
        Task<bool> UserExistsByUserNameAsync(string userName);

        Task<User> GetByEmailOrUserNameAsync(string emailOrUserName);

        Task BanUserAsync(string userName);

        Task<IList<User>> GetAllForToplistAsync();

        Task<bool> IsEmailRegisteredAsync(string emailToVerify);

        Task<bool> IsEmailAlreadyVerifiedAsync(string userName, string emailToVerify);

        Task<bool> SetEmailAsync(string userName, string emailToVerify);

        Task<User> GetByPasswordResetCodeIdAsync(Guid resetCodeId);
        
        Task<int> getCountOfAllAsync();

        Task<ClientIdentity> GetIdentityByTokenValuesAsync(string baseValue, string encryptedValue);
    }
}
