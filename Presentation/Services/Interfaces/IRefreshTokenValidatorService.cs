using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IRefreshTokenValidatorService
    {
        Task<RefreshTokenDTO> GenerateNewTokenForAuthAsync(Guid userId);

        Task<User> ValidateAsync(RefreshTokenDTO refreshTokenDTO, bool isUserAuthenticated);
    }
}
