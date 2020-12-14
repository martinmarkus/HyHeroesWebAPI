using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IEmailVerificationCodeRepository : IAsyncRepository<EmailVerificationCode>
    {
        Task<bool> IsCodeValidAsync(Guid activationCode);

        Task UpdateCodeStateAsync(Guid activationCode);

        Task<bool> HasActiveUnusedCodeAsync(string userName);
    }
}
