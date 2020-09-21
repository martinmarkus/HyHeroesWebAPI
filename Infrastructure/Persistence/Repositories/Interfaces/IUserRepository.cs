﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUserNameAsync(string email);

        Task<User> GetByEmailOrUserNameAndPasswordAsync(string emailOrUserName, string password);

        Task<bool> UserAlreadyExistsByNewUserAsync(NewUser newUser);

        Task<bool> UserExistsByEmailAsync(string email);
        
        Task<bool> UserExistsByUserNameAsync(string userName);

        Task<User> GetByEmailOrUserNameAsync(string emailOrUserName);

        Task BanUserAsync(string userName);

        Task<IList<User>> GetAllForToplistAsync();
    }
}
