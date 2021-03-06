using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IKreditGiftingMapper
    {
        UserKreditGiftingsDTO MapToGiftingDTO(KreditGift gift);

        UserKreditGiftingsListDTO MapToGiftingListDTO(IList<KreditGift> kreditGiftings);
    }
}
