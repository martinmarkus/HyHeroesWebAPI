using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IUserMapper
    {
        NewUser MapToNewUser(NewUserDTO userDTO);

        User MapToUser(
            NewUser newUser,
            Guid roleId,
            string IP);

        UserDTO MapToUserDTO(User user);

        AuthenticatedUserDTO MapToAuthenticatedUserDTO(User user);

        IList<ToplistElementDTO> MapToToplistElementDTOs(IList<User> users);

        BarionPaymentTransactionDTO MapToPaymentTransactionDTO(KreditPurchaseTransactionDTO kreditTransactionDTO);
    }
}
