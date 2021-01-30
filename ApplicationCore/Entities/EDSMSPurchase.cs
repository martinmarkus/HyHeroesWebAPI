namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class EDSMSPurchase : BaseEntity
    {
        public string ActivationCode { get; set; }

        public int GrossPrice { get; set; }
    }
}
