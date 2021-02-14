using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Utils;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class RefreshTokenValidatorService : IRefreshTokenValidatorService
    {
        private const int REFRESH_TOKEN_LENGTH = 64;
        private readonly int _refreshTokenValidityMins;

        private readonly IAuthenticationService _authenticationService;
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly RandomStringGenerator<RandomCodeContainer> _randomStringGenerator;
        private readonly IOptions<AppSettings> _appSettings;

        public RefreshTokenValidatorService(
            IAuthenticationService authenticationService,
            IRefreshTokenRepository refreshTokenRepository,
            RandomStringGenerator<RandomCodeContainer> randomStringGenerator,
            IOptions<AppSettings> appSettings)
        {
            _authenticationService = authenticationService ?? throw new ArgumentException(nameof(authenticationService));
            _refreshTokenRepository = refreshTokenRepository ?? throw new ArgumentException(nameof(refreshTokenRepository));
            _randomStringGenerator = randomStringGenerator ?? throw new ArgumentException(nameof(randomStringGenerator));
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));

            _refreshTokenValidityMins = Math.Abs(_appSettings.Value.SessionTokenValidityMins + 10);
        }

        public async Task<User> ValidateAsync(RefreshTokenDTO refreshTokenDTO, bool isUserAuthenticated)
        {
            // INFO: If the user is still authenticated, can't request new refresh token.
            if (isUserAuthenticated)
            {
                throw new UnauthorizedAccessException();
            }

            // INFO: If the receiverd refresh token is not found, or expired, return 401.
            var token = await _refreshTokenRepository.GetByTokenValueAsync(refreshTokenDTO.TokenValue);
            if (token == null)
            {
                throw new UnauthorizedAccessException();
            }

            var newTokenValue = _randomStringGenerator.GetRandomString(Math.Abs(REFRESH_TOKEN_LENGTH));

            token.TokenValue = newTokenValue;
            token.ExpirationDate = DateTime.Now.AddMinutes(_refreshTokenValidityMins);

            await _refreshTokenRepository.UpdateAsync(token);

            return await _authenticationService.InstantAuthenticateAsync(refreshTokenDTO.UserName);
        }

        public async Task<RefreshTokenDTO> GenerateNewTokenForAuthAsync(Guid userId)
        {
            var newTokenValue = _randomStringGenerator.GetRandomString(Math.Abs(REFRESH_TOKEN_LENGTH));
            var token = await _refreshTokenRepository.GetByUserIdAsync(userId);

            if (token == null)
            {
                await _refreshTokenRepository.AddAsync(new RefreshToken()
                {
                    TokenValue = newTokenValue,
                    ExpirationDate = DateTime.Now.AddMinutes(_refreshTokenValidityMins),
                    UserId = userId
                });
            }
            else
            {
                token.TokenValue = newTokenValue;
                token.ExpirationDate = DateTime.Now.AddMinutes(Math.Abs(_refreshTokenValidityMins));
                await _refreshTokenRepository.UpdateAsync(token);
            }

            return new RefreshTokenDTO()
            {
                TokenValue = newTokenValue
            };
        }
    }
}
