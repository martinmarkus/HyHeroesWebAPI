using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class KreditGiftingMapper : IKreditGiftingMapper
    {
        public UserKreditGiftingsListDTO MapToGiftingListDTO(IList<KreditGift> kreditGiftings)
        {
            var dto = new UserKreditGiftingsListDTO();

            foreach (var gift in kreditGiftings)
            {
                dto.UserKreditGiftings.Add(MapToGiftingDTO(gift));
            }

            return dto;
        }

        public UserKreditGiftingsDTO MapToGiftingDTO(KreditGift gift) =>
            new UserKreditGiftingsDTO()
            {
                GiftingDate = gift.CreationDate,
                KreditValue = gift.KreditGiftAmount,
                ReceiverUserName = gift.ReceiverUser?.UserName,
                SenderUserName = gift.SenderUser?.UserName
            };
    }
}
