using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class PayPalMapper : IPayPalMapper
    {
        public FinishedPayPalTransactionDTO MapToFinishedTransactionDTO(PayPalOrder order) =>
            new FinishedPayPalTransactionDTO()
            {
                KreditAmount = order.KreditAmount,
                OrderId = order.OrderId
            };

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
