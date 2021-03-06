﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class MassKreditCodeMapper : IMassKreditCodeMapper
    {
        public ActiveMassKreditCodesDTO MapToActiveMassKreditCodesDTO(IList<MassKreditActivationCode> codes)
        {
            var activeMassKreditCodesDTO = new ActiveMassKreditCodesDTO();

            foreach(var code in codes)
            {
                activeMassKreditCodesDTO.ActiveMassKreditCodes.Add(
                    MapToMassKreditCodeDTO(code));
            }

            return activeMassKreditCodesDTO;
        }

        public MassKreditCodeDTO MapToMassKreditCodeDTO(MassKreditActivationCode code) =>
            new MassKreditCodeDTO()
            {
                Code = code.Code,
                KreditValue = code.KreditValue,
                StartDate = code.StartDate,
                ExpirationDate = code.ExpirationDate,
                ActivationAmount = code.MassKreditUserActivations.Count
            };
    }
}
