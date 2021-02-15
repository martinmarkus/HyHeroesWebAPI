using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Mappers.Interfaces
{
    public interface IBillMapper
    {
        SzamlazzHuBillDTO Map(CreateBillDTO createBillDTO);
    }
}
