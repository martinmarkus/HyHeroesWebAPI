using HyHeroesWebAPI.ApplicationCore.Enums;

namespace HyHeroesWebAPI.Presentation.DTOs.EconomyDTOs
{
    public class PaymentTypeStatDTO
    {
        public PaymentType PaymentType { get; set; }

        public int PurchaseCount { get; set; }

        public int PurchaseCurrencySum { get; set; }

        public int PurchaseKreditSum { get; set; }
    }
}
