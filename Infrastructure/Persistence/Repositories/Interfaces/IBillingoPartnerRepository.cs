﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IBillingoPartnerRepository : IAsyncRepository<BillingoPartner>
    {
        Task<BillingoPartner> GetByUserIdAsync(Guid userId);
    }
}
