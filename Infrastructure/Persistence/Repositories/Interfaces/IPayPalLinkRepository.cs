using System;
using System.Collections.Generic;
using System.Text;
using HyHeroesWebAPI.ApplicationCore.Entities;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPayPalLinkRepository : IAsyncRepository<PayPalLink>
    {
    }
}
