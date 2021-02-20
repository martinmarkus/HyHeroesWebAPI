using HyHeroesWebAPI.ApplicationCore.DataObjects;
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

        Task<ClientIdentity> GetIdentityByTokenValuesAsync(string baseValue, string encryptedValue);

        Task BanUserAsync(BanUserDTO banUserDTO);

        Task<ClientIdentity> GetIdentityByUserNameAsync(string userName);

        Task<IList<ToplistElementDTO>> GetTopListAsync();

        Task UpdateUserAsync(UpdateUserDTO userDTO);

        Task<IList<RoleDTO>> GetAllRolesAsync();
        
        Task SendEmailVerifyCodeAsync(string userName, string emailToVerify);

        Task VerifyEmailAsync(Guid activationCode);

        Task SendPasswordResetEmailAsync(string emailOrUserName);

        Task ResetPasswordAsync(ResetForgottenPasswordDTO resetForgottenPasswordDTO);

        Task<ClientIdentity> GenerateNewClientIdentityValuesAsync(ClientIdentity clientIdentity);

        Task<bool> CheckResetCodeAsync(Guid resetCode);
        
        Task VerifyPasswordAsync(string userName, string password);

        Task<UserNameDTO> GetUserNameByPasswordResetCodeAsync(Guid resetCodeId);
       
        Task<RegisteredUserCountDTO> GetRegisteredUserCountAsync();

        Task UpdateServerPlayerStateAsync(ServerPlayerStateDTO serverPlayerStateDTO);

        Task<OnlinePlayerCountDTO> GetOnlinePlayerCountAsync();
        
        Task ResetPlayerStatesAsync();

        Task<ClientIdentity> GenerateNewClientIdentityValuesAsync(string userName);

        Task<BannedIPListDTO> GetLastBannedIPsAsync(int banCount);

        Task SetIPBanStateAsync(BanStateDTO banStateDTO);

        Task<BannedIPDTO> GetIPInfoAsync(string iP);

        Task<AggregatedOnlinePlayerCountDTOList> GetAggregatedOnlinePlayerCountAsync();

        Task SendKreditGiftAsync(SendKreditGiftDTO sendKreditGiftDTO, string userName);
    }
}
