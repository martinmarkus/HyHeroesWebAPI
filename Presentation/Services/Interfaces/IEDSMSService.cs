﻿using HyHeroesWebAPI.Presentation.DTOs.EDSMSDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IEDSMSService
    {
        Task<AppliedEDSMSKreditDTO> ApplyJatekFizetesCallAsync(ApplyKreditDTO applyKreditDTO, string clientIP);

        EDSMSPurchaseTypeListDTO GetEDSMSPurchaseTypes();
    }
}
