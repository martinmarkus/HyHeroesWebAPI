using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using SzamlazzHuService.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBillingMapper
    {
        BillingTransaction MapToBillingTransaction(KreditPurchaseTransactionDTO kreditTransactionDTO, string email);

        CreateBillDTO MapToCreateBillDTO(BillingTransaction billingTransaction, SellerData sellerData, decimal purchasedKreditPrice);
    }
}
