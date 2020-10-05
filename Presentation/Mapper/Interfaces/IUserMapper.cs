using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IUserMapper
    {
        NewUser MapToNewUser(NewUserDTO userDTO);

        User MapToUser(
            NewUser newUser,
            Guid roleId);

        UserDTO MapToUserDTO(User user);

        AuthenticatedUserDTO MapToAuthenticatedUserDTO(User user);

        IList<ToplistElementDTO> MapToToplistElementDTOs(IList<User> users);

        PaymentTransactionDTO MapToPaymentTransactionDTO(KreditPurchaseTransactionDTO kreditTransactionDTO);
        NewUser MapToNewUser(NewUserWithoutEmailDTO newUserWithoutEmailDTO);
    }
}