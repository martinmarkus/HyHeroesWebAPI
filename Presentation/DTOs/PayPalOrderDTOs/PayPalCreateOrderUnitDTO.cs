namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalCreateOrderUnitDTO
    {
        public PayPalCreateOrderAmountDTO amount { get; set; }

        public string description { get; set; }
    }
}
