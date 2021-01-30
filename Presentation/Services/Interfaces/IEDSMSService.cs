using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IEDSMSService
    {
        Task<AppliedEDSMSKreditDTO> ApplyJatekFizetesCallAsync(ApplyKreditDTO applyKreditDTO);
     
        IList<EDSMSPurchaseTypeDTO> GetEDSMSPurchaseTypes();
    }
}
