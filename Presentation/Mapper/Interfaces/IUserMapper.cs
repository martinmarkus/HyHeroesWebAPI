using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.DTOs;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IUserMapper
    {
        NewUser MapToNewUser(NewUserDTO userDTO);

        User MapToUser(
            NewUser newUser,
            Guid roleId);
    }
}