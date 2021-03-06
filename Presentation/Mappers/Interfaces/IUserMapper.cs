﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Presentation.DTOs.BarionDTOs;
using HyHeroesWebAPI.Presentation.DTOs.ProductDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IUserMapper
    {
        NewUser MapToNewUser(NewUserDTO userDTO);

        User MapToNewRegisterUser(
            NewUser newUser,
            Guid roleId,
            string IP);

        UserDTO MapToUserDTO(User user);

        AuthenticatedUserDTO MapToAuthenticatedUserDTO(User user);

        IList<ToplistElementDTO> MapToToplistElementDTOs(IList<User> users);

        BarionPaymentTransactionDTO MapToPaymentTransactionDTO(KreditPurchaseTransactionDTO kreditTransactionDTO);

        AcceptedCountryListDTO MapToAcceptedCountriesListDTO(IList<AcceptedCountry> acceptedCountries);
    }
}
