using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.DTOs;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class UserMapper : IUserMapper
    {

        private readonly IPasswordEncryptorService _passwordEncryptorService;

        public UserMapper(IPasswordEncryptorService passwordEncryptorService)
        {
            _passwordEncryptorService = passwordEncryptorService ?? throw new ArgumentNullException(nameof(passwordEncryptorService));
        }

        public NewUser MapToNewUser(NewUserDTO userDTO)
        {
            var passwordSalt = _passwordEncryptorService.CreateSalt();
            var passwordHash = _passwordEncryptorService.CreateHash(userDTO.Password, passwordSalt);

            return new NewUser()
            {
                UserName = userDTO.UserName,
                Email = userDTO.Email,
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash,
                LastAuthenticationIp = userDTO.LastAuthenticationIp
            };
        }

        public User MapToUser(NewUser newUser, Guid roleId)
        {
            return new User()
            {
                UserName = newUser.UserName,
                Email = newUser.Email,
                Currency = 0,
                PasswordHash = newUser.PasswordHash,
                PasswordSalt = newUser.PasswordSalt,
                RegistrationDate = DateTime.Now,
                RoleId = roleId,
                LastAuthenticationIp = newUser.LastAuthenticationIp,
                LastAuthenticationDate = DateTime.Now,
                IsBanned = false,
                //Role = new Role()
                //{

                //}
            };
        }
    }
}
