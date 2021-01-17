using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Utils;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class MassKreditActivationService : IMassKreditActivationService
    {
        private readonly IMassKreditActivationCodeRepository _massKreditActivationCodeRepository;
        private readonly IMassKreditUserActivationRepository _massKreditUserActivationRepository;
        private readonly IUserRepository _userRepository;

        private readonly IMassKreditCodeMapper _massKreditCodeMapper;

        private readonly RandomStringGenerator<MassKreditActivationCode> _randomStringGenerator;

        public MassKreditActivationService(
            IMassKreditActivationCodeRepository massKreditActivationCodeRepository,
            IMassKreditUserActivationRepository kreditUserActivationRepository,
            IUserRepository userRepository,
            IMassKreditCodeMapper massKreditCodeMapper,
            RandomStringGenerator<MassKreditActivationCode> randomStringGenerator)
        {
            _massKreditActivationCodeRepository = massKreditActivationCodeRepository ?? throw new ArgumentException(nameof(massKreditActivationCodeRepository));
            _massKreditUserActivationRepository = kreditUserActivationRepository ?? throw new ArgumentException(nameof(kreditUserActivationRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));

            _massKreditCodeMapper = massKreditCodeMapper ?? throw new ArgumentException(nameof(massKreditCodeMapper));

            _randomStringGenerator = randomStringGenerator ?? throw new ArgumentException(nameof(randomStringGenerator));
        }

        public async Task ActivateMassKreditCodeAsync(
            MassKreditCodeActivationDTO massKreditCodeActivationDTO,
            string userName)
        {
            var existingUser = await _userRepository.GetByUserNameAsync(userName);

            if (existingUser == null)
            {
                throw new NotFoundException();
            }

            var massCode = await _massKreditActivationCodeRepository.GetByKreditCodeAsync(massKreditCodeActivationDTO.KreditCode);

            if (massCode == null)
            {
                throw new NotFoundException();
            }

            var userActivation = await _massKreditUserActivationRepository.GetByUserNameAndMassKreditIdAsync(
                userName,
                massCode.Id);

            if (userActivation != null)
            {
                throw new MassKreditCodeAlreadyActivatedException(massCode.Code, userName);
            }

            await _massKreditUserActivationRepository.AddAsync(new MassKreditUserActivation()
            {
                ActivationDate = DateTime.Now,
                User = existingUser,
                UserId = existingUser.Id,
                MassKreditActivationCode = massCode,
                MassKreditActivationCodeId = massCode.Id
            });

            // INFO: increasing user currency
            existingUser.Currency += massCode.KreditValue;
            await _userRepository.UpdateAsync(existingUser);
        }

        public async Task<MassKreditCodeDTO> AddMassKreditCodeAsync(NewMassKreditCodeDTO newMassKreditCodeDTO)
        {
            var activeMassKreditCodes = await _massKreditActivationCodeRepository.GetAllActiveCodesAsync();

            if (activeMassKreditCodes == null)
            {
                throw new Exception();
            }

            var code = _randomStringGenerator.GetRandomString(activeMassKreditCodes, 4);

            var addedCode = await _massKreditActivationCodeRepository.AddAsync(new MassKreditActivationCode()
            {
                Code = code,
                StartDate = newMassKreditCodeDTO.StartDate,
                ExpirationDate = newMassKreditCodeDTO.ExpirationDate,
                KreditValue = newMassKreditCodeDTO.KreditValue
            });

            return new MassKreditCodeDTO()
            {
                Code = addedCode.Code,
                KreditValue = addedCode.KreditValue,
                StartDate = addedCode.StartDate,
                ExpirationDate = addedCode.ExpirationDate
            };
        }

        public async Task RemoveMassKreditCodeAsync(RemoveMassKreditCodeDTO removeMassKreditCodeDTO) =>
            await _massKreditActivationCodeRepository.RemoveByKreditCodeAsync(removeMassKreditCodeDTO.Code);

        public async Task<ActiveMassKreditCodesDTO> GetAllActiveMassKreditCodesAsync() =>
            _massKreditCodeMapper.MapToActiveMassKreditCodesDTO(
                await _massKreditActivationCodeRepository.GetAllActiveCodesAsync());
    }
}
