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

        Task ResetKreditAsync(Guid userId);

        Task<User> GetByEmailAsync(string email);

        Task<User> GetByIdAsync(Guid id);

        Task UpdateUser(UserDTO user);
    }
}