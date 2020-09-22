using HyHeroesWebAPI.ApplicationCore.Entities;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public interface IEDSMSMapper
    {
        EDSMSPurchase MapToEDSMSPurchase(
            string id,
            string prefix,
            string message,
            string to,
            string from,
            string tariff,
            string test);
    }
}
