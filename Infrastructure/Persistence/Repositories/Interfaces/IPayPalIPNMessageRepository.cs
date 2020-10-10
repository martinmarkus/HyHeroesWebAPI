using HyHeroesWebAPI.ApplicationCore.Entities;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPayPalIPNMessageRepository : IAsyncRepository<PayPalIPNMessage>
    {
    }
}
