using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IAuthenticationResultDTOMapper
    {
        AuthenticatedUserDTO Map(User user);
    }
}