using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPasswordResetCodeRepository : IAsyncRepository<PasswordResetCode>
    {
        Task<PasswordResetCode> GetByUnusedCodeAsync(Guid resetCode);
    }
}
