using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IEDSMSService
    {
        Task<AppliedEDSMSKreditDTO> ApplyKreditAsync(ApplyKreditDTO applyKreditDTO);
        Task<List<EDSMSActivationCode>> GenerateActivationCodesAsync(int codeAmount, int kreditValue);
        IList<EDSMSPurchaseTypeDTO> GetEDSMSPurchaseTypes();
        Task<EDSMSActivationCode> ProcessEDSMSAsync(EDSMSPurchase EDSMSDTO);
    }
}
