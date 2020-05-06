﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IUserService
    {
        Task<decimal> AddKreditAsync(KreditTransactionDTO kreditUploadDTO);

        Task<decimal> RemoveKreditAsync(KreditTransactionDTO kreditTransactionDTO);

        Task<decimal> ResetKreditAsync(string userName);

        Task<int> AddHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO);

        Task<int>RemoveHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO);

        Task<int>ResetHyCoinAsync(string userName);

        Task<User> GetByIdAsync(Guid userId);

        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUserNameAsync(string userName);

        Task ChangePasswordAsync(string email, string oldPassword, string newPassword);

        Task BanUserAsync(BanUserDTO banUserDTO);
    }
}
