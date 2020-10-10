using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IUserService
    {
        Task<decimal> AddKreditAsync(KreditTransactionDTO kreditUploadDTO);

        Task<bool> PurchaseKreditAsync(KreditPurchaseTransactionDTO kreditUploadDTO);

        Task<decimal> RemoveKreditAsync(KreditTransactionDTO kreditTransactionDTO);

        Task<decimal> ResetKreditAsync(string userName);

        Task<int> AddHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO);

        Task<int>RemoveHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO);

        Task<int>ResetHyCoinAsync(string userName);

        Task<User> GetByIdAsync(Guid userId);

        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUserNameAsync(string userName);

        Task<UserDTO> GetByUserNameOrEmailAsync(string userNameOrEmail);

        Task ChangePasswordAsync(string userName, string oldPassword, string newPassword);

        Task BanUserAsync(BanUserDTO banUserDTO);

        Task<IList<ToplistElementDTO>> GetTopListAsync();

        Task UpdateUserAsync(UpdateUserDTO userDTO);

        Task<IList<RoleDTO>> GetAllRolesAsync();
    }
}
