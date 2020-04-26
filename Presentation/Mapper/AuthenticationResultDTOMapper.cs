using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Constants;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class AuthenticationResultDTOMapper : IAuthenticationResultDTOMapper
    {
        private readonly ITokenGeneratorService _tokenGeneratorService;

        public AuthenticationResultDTOMapper(ITokenGeneratorService tokenGeneratorService)
        {
            _tokenGeneratorService = tokenGeneratorService ?? throw new ArgumentNullException(nameof(tokenGeneratorService));
        }

        public AuthenticatedUserDTO Map(User user) => new AuthenticatedUserDTO()
        {
            UserName = user.UserName,
            Email = user.Email,
            Currency = user.Currency.ToString(),
            Id = user.Id.ToString(),
            Role = user.Role.Name,
            Token = _tokenGeneratorService.GenerateToken(user.Email),
            IsBanned = user.IsBanned.ToString(),
            ExpiresIn = TokenConstants.TokenTimeInMinutes.ToString(),
        };
    }
}