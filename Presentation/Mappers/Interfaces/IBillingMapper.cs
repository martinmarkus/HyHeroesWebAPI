using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IBillingMapper
    {
        BillingTransaction MapToBillingTransaction(CreateBillingoBillDTO dto, bool isBilled);

        BillingoPartnerDTO MapToPartnerDTO(BillingoPartner partner);
    }
}
