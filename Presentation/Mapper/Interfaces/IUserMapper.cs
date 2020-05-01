using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Presentation.DTOs;
using System;

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
    }
}