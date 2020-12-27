using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Constants;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Models;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class UserMapper : IUserMapper
    {
        private readonly IPasswordEncryptorService _passwordEncryptorService;
        private readonly ITokenGeneratorService _tokenGeneratorService;
        private readonly ValueConverter _valueConverter;
        public UserMapper(
            IPasswordEncryptorService passwordEncryptorService,
            ITokenGeneratorService tokenGeneratorService,
            ValueConverter valueConverter)
        {
            _passwordEncryptorService = passwordEncryptorService ?? throw new ArgumentNullException(nameof(passwordEncryptorService));
            _tokenGeneratorService = tokenGeneratorService ?? throw new ArgumentNullException(nameof(tokenGeneratorService));
            _valueConverter = valueConverter ?? throw new ArgumentNullException(nameof(valueConverter));
        }

        public AuthenticatedUserDTO MapToAuthenticatedUserDTO(User user)
        {
            if (user == null)
            {
                throw new NotFoundException();
            }

            return new AuthenticatedUserDTO()
            {
                UserName = user.UserName,
                Email = _valueConverter.GetCheckedString(user.Email),
                Currency = user.Currency.ToString(),
                HyCoin = user.HyCoin.ToString(),
                Id = user.Id.ToString(),
                Role = user.Role.Name,
                Token = _tokenGeneratorService.GenerateToken(user.UserName),
                IsBanned = user.IsBanned.ToString(),
                ExpiresIn = TokenConstants.TokenTimeInMinutes.ToString(),
                LastAuthenticationDate = user.LastAuthenticationDate.ToString(),
                LastAuthenticationIp = user.LastAuthenticationIp
            };
        }

        public NewUser MapToNewUser(NewUserDTO userDTO)
        {
            var passwordSalt = _passwordEncryptorService.CreateSalt();
            var passwordHash = _passwordEncryptorService.CreateHash(userDTO.Password, passwordSalt);

            return new NewUser()
            {
                UserName = userDTO.UserName,
                //Email = _valueConverter.GetCheckedString(userDTO.Email),
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash
            };
        }

        public NewUser MapToNewUser(NewUserWithoutEmailDTO userDTO)
        {
            var passwordSalt = _passwordEncryptorService.CreateSalt();
            var passwordHash = _passwordEncryptorService.CreateHash(userDTO.Password, passwordSalt);

            return new NewUser()
            {
                UserName = userDTO.UserName,
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash
            };
        }

        public IList<ToplistElementDTO> MapToToplistElementDTOs(IList<User> users)
        {
            var elements = new List<ToplistElementDTO>();

            foreach (var user in users)
            {
                elements.Add(new ToplistElementDTO()
                {
                    UserName = user.UserName,
                    HyCoin = user.HyCoin
                });
            }

            return elements;
        }

        public User MapToUser(NewUser newUser, Guid roleId) =>
            new User()
            {
                UserName = newUser.UserName,
                Email = _valueConverter.GetCheckedString(newUser.Email),
                Currency = 0,
                PasswordHash = newUser.PasswordHash,
                PasswordSalt = newUser.PasswordSalt,
                RegistrationDate = DateTime.Now,
                RoleId = roleId,
                LastAuthenticationIp = newUser.LastAuthenticationIp,
                LastAuthenticationDate = DateTime.Now,
                IsBanned = false,
            };

        public UserDTO MapToUserDTO(User user)
        {
            if (user == null)
            {
                throw new NotFoundException();
            }
            return new UserDTO()
            {
                UserName = user.UserName,
                Email = _valueConverter.GetCheckedString(user.Email),
                Currency = user.Currency.ToString(),
                HyCoin = user.HyCoin.ToString(),
                RegistrationDate = user.RegistrationDate.ToString(),
                LastAuthenticationDate = user.LastAuthenticationDate.ToString(),
                LastAuthenticationIp = user.LastAuthenticationIp,
                IsBanned = user.IsBanned,
                RoleName = user.Role.Name
            };
        }

        public PaymentTransactionDTO MapToPaymentTransactionDTO(KreditPurchaseTransactionDTO kreditTransactionDTO) =>
            new PaymentTransactionDTO();
    }
}
