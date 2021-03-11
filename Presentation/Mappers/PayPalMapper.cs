using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class PayPalMapper : IPayPalMapper
    {
        public PayPalPurchaseTypeListDTO MapToPayPalPurchaseTypeListDTO(PayPalPurchaseType[] payPalPurchaseTypes)
        {
            var dto = new PayPalPurchaseTypeListDTO();
            foreach (var type in payPalPurchaseTypes)
            {
                dto.PayPalPurchaseTypes.Add(type);
            }
            return dto;
        }
    }
}
