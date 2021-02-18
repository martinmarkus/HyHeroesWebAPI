using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IBillingMapper
    {
        BillingTransaction MapToBillingTransaction(KreditPurchaseTransactionDTO kreditTransactionDTO, string email);

        CreateBillDTO MapToCreateBillDTO(
            BillingTransaction billingTransaction,
            SellerData sellerData,
            SzamlazzHuConfig szamlazzHuConfig,
            decimal purchasedKreditPrice,
            int purchasedKreditValue,
            PaymentType paymentType);

        BillingTransaction MapToBillingTransaction(CreateBillingoBillDTO dto, string email);

        BillingoPartnerDTO MapToPartnerDTO(BillingoPartner partner);

        BillingoPartner MapToPartnerDTO(BillingoPartnerDTO partnerDTO);
    }
}
