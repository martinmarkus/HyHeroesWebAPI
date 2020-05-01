using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IUserService
    {
        Task AddKreditAsync(KreditTransactionDTO kreditUploadDTO);

        Task RemoveKreditAsync(KreditTransactionDTO kreditTransactionDTO);

        Task ResetKreditAsync(string userName);

        Task AddHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO);

        Task RemoveHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO);

        Task ResetHyCoinAsync(string userName);

        Task<User> GetByIdAsync(Guid userId);

        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUserNameAsync(string userName);

        Task ChangePasswordAsync(string email, string password);

        Task BanUserAsync(BanUserDTO banUserDTO);
    }
}
