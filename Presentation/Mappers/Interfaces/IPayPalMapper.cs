using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IPayPalMapper
    {
        PayPalPurchaseTypeListDTO MapToPayPalPurchaseTypeListDTO(PayPalPurchaseType[] payPalPurchaseTypes);
    }
}
