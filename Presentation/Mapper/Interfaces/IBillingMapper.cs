using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBillingMapper
    {
        BillingTransaction MapToBillingTransaction(KreditPurchaseTransactionDTO kreditTransactionDTO, string email);

        CreateBillDTO MapToCreateBillDTO(
            BillingTransaction billingTransaction,
            SellerData sellerData,
            decimal purchasedKreditPrice,
            int purchasedKreditValue,
            PaymentType paymentType);
    }
}
