using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Infrastructure.Utils;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IEmailVerificationCodeRepository _verificationCodeRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;
        private readonly IPasswordResetCodeRepository _passwordResetCodeRepository;
        private readonly IClientIdentityRepository _clientIdentityRepository;
        private readonly IGameServerRepository _gameServerRepository;
        private readonly IOnlinePlayerStateRepository _onlinePlayerStateRepository;
        private readonly IBlacklistedIPRepository _blacklistedIPRepository;

        private readonly IStringEncryptorService _stringEncryptorService;
        private readonly IEmailSenderService _emailSenderService;
        private readonly INotificationService _notificationService;

        private readonly IBannedIpMapper _bannedIpMapper;
        private readonly IUserMapper _userMapper;
        private readonly IOnlinePlayerCountMapper _onlinePlayerCountMapper;

        private readonly ValueConverter _valueConverter;
        private readonly RandomStringGenerator<RandomCodeContainer> _randomStringGenerator;

        private IUnitOfWork _unitOfWork;

        private readonly IOptions<AppSettings> _appSettingsOptions;

        public UserService(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            IBlacklistedIPRepository blacklistedIPRepository,
            IUserMapper userMapper,
            IStringEncryptorService passwordEncryptorService,
            IEmailSenderService emailSenderService,
            INotificationService notificationService,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IEmailVerificationCodeRepository verificationCodeRepository,
            IPasswordResetCodeRepository passwordResetCodeRepository,
            IGameServerRepository gameServerRepository,
            IOnlinePlayerStateRepository onlinePlayerStateRepository,
            IClientIdentityRepository clientIdentityRepository,
            IBannedIpMapper bannedIpMapper,
            IOnlinePlayerCountMapper onlinePlayerCountMapper,
            IUnitOfWork unitOfWork,
            ValueConverter valueConverter,
            RandomStringGenerator<RandomCodeContainer> randomStringGenerator,
            IOptions<AppSettings> appSettingsOptions)
        {
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _roleRepository = roleRepository ?? throw new ArgumentException(nameof(roleRepository));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
            _bannedIpMapper = bannedIpMapper ?? throw new ArgumentException(nameof(bannedIpMapper));
            _onlinePlayerCountMapper = onlinePlayerCountMapper ?? throw new ArgumentException(nameof(onlinePlayerCountMapper));

            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));
            _stringEncryptorService = passwordEncryptorService ?? throw new ArgumentException(nameof(passwordEncryptorService));
            _emailSenderService = emailSenderService ?? throw new ArgumentException(nameof(emailSenderService));
            _valueConverter = valueConverter ?? throw new ArgumentException(nameof(valueConverter));     
            
            _verificationCodeRepository = verificationCodeRepository ?? throw new ArgumentException(nameof(verificationCodeRepository));
            _passwordResetCodeRepository = passwordResetCodeRepository ?? throw new ArgumentException(nameof(passwordResetCodeRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _blacklistedIPRepository = blacklistedIPRepository ?? throw new ArgumentException(nameof(blacklistedIPRepository));
            
            _onlinePlayerStateRepository = onlinePlayerStateRepository ?? throw new ArgumentException(nameof(onlinePlayerStateRepository));
            _gameServerRepository = gameServerRepository ?? throw new ArgumentException(nameof(gameServerRepository));
            _clientIdentityRepository = clientIdentityRepository ?? throw new ArgumentException(nameof(clientIdentityRepository));

            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
            _appSettingsOptions = appSettingsOptions ?? throw new ArgumentException(nameof(appSettingsOptions));
            _randomStringGenerator = randomStringGenerator ?? throw new ArgumentException(nameof(randomStringGenerator));
        }

        public async Task ChangePasswordAsync(string userName, string oldPassword, string newPassword)
        {
            var existingUser = await _userRepository.GetByUserNameAsync(userName);
            if (existingUser == null)
            {
                throw new NotFoundException();
            }
            else if (!userName.ToLower().Equals(existingUser.UserName.ToLower()))
            {
                throw new NoPermissionException();
            }

            var oldHash = _stringEncryptorService.CreateHash(oldPassword, existingUser.PasswordSalt);
            if (!oldHash.Equals(existingUser.PasswordHash, StringComparison.Ordinal))
            {
                throw new WrongPasswordException();
            }

            existingUser.PasswordHash = _stringEncryptorService
                .CreateHash(newPassword, existingUser?.PasswordSalt);

            await _userRepository.UpdateAsync(existingUser);
        }

        public async Task<User> GetByEmailAsync(string email) =>
            await _userRepository.GetByEmailAsync(email);

        public async Task<User> GetByIdAsync(Guid id) =>
            await _userRepository.GetByIdAsync(id);

        public async Task<User> GetByUserNameAsync(string userName) =>
             await _userRepository.GetByUserNameAsync(userName);

        public async Task<decimal> AddKreditAsync(KreditTransactionDTO kreditUploadDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(kreditUploadDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency += Math.Abs(kreditUploadDTO.KreditValue);
            await _userRepository.UpdateAsync(user);

            return user.Currency;
        }

        public async Task PurchaseKreditAsync(KreditPurchaseTransactionDTO kreditUploadDTO)
        {
            try
            {
                // INFO: payment adding
                var user = await _userRepository.GetByUserNameAsync(kreditUploadDTO.UserName);
                if (user == null)
                {
                    throw new NotFoundException();
                }

                user.Currency += Math.Abs(kreditUploadDTO.KreditValue);
                await _userRepository.UpdateAsync(user);

                await _kreditPurchaseRepository.AddAsync(new KreditPurchase()
                {
                    KreditValue = kreditUploadDTO.KreditValue,
                    CurrencyValue = kreditUploadDTO.CurrencyValue,
                    User = user,
                    UserId = user.Id,
                    PaymentType = kreditUploadDTO.PaymentType
                });

                // INFO: sending bill creation request to szamlazz.hu
                //var billingTransaction = _billingMapper.MapToBillingTransaction(kreditUploadDTO, user.Email);
                //await _billingTransactionRepository.AddAsync(billingTransaction);

                //var isBilled = await CreateBillAsync(
                //    billingTransaction,
                //    kreditUploadDTO.KreditValue,
                //    kreditUploadDTO.CurrencyValue,
                //    kreditUploadDTO.PaymentType);

                //if (!isBilled)
                //{
                //    throw new BillingException();
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<decimal> RemoveKreditAsync(KreditTransactionDTO kreditTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(kreditTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var kreditAbs = Math.Abs(kreditTransactionDTO.KreditValue);
            if (user.Currency - kreditAbs >= 0)
            {
                user.Currency -= kreditAbs;
            }
            else
            {
                user.Currency = 0;
            }

            await _userRepository.UpdateAsync(user);
            return user.Currency;
        }

        public async Task<decimal> ResetKreditAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency = 0;
            await _userRepository.UpdateAsync(user);

            return user.Currency;
        }

        public async Task<int> AddHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(hyCoinTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.HyCoin += Math.Abs(hyCoinTransactionDTO.HyCoin);
            await _userRepository.UpdateAsync(user);

            return user.HyCoin;
        }

        public async Task<int> RemoveHyCoinAsync(HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(hyCoinTransactionDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var hyCoinAbs = Math.Abs(hyCoinTransactionDTO.HyCoin);

            if (user.HyCoin - hyCoinAbs >= 0)
            {
                user.HyCoin -= hyCoinAbs;
            }
            else
            {
                user.HyCoin = 0;
            }

            await _userRepository.UpdateAsync(user);
            return user.HyCoin;
        }

        public async Task<int> ResetHyCoinAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.HyCoin = 0;
            await _userRepository.UpdateAsync(user);

            return user.HyCoin;
        }

        public async Task BanUserAsync(BanUserDTO banUserDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(banUserDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            if (user.IsBanned)
            {
                throw new UserAlreadyBannedException();
            }

            await _userRepository.BanUserAsync(banUserDTO.UserName);
        }

        public async Task<IList<ToplistElementDTO>> GetTopListAsync() =>
            _userMapper.MapToToplistElementDTOs(
                await _userRepository.GetAllForToplistAsync());

        public async Task<UserDTO> GetByUserNameOrEmailAsync(string userNameOrEmail) =>
            _userMapper.MapToUserDTO(
                await _userRepository.GetByEmailOrUserNameAsync(userNameOrEmail));

        public async Task UpdateUserAsync(UpdateUserDTO userDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(userDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency = _valueConverter.ConvertToInt(userDTO.Currency, user.Currency);
            user.HyCoin = _valueConverter.ConvertToInt(userDTO.HyCoin, user.HyCoin);
            user.IsBanned = _valueConverter.ConvertToBool(userDTO.IsBanned, user.IsBanned);

            var newRole = await _roleRepository.GetRoleByNameAsync(userDTO.RoleName);
            user.Role = newRole;
            user.RoleId = newRole.Id;

            await _userRepository.UpdateAsync(user);
        }

        public async Task<IList<RoleDTO>> GetAllRolesAsync()
        {
            var roles = await _roleRepository.GetAllAsync();
            var roleDTOs = new List<RoleDTO>();

            foreach (var role in roles)
            {
                roleDTOs.Add(new RoleDTO()
                { 
                    Name = role.Name
                });
            }

            return roleDTOs;
        }

        public async Task SendEmailVerifyCodeAsync(string userName, string emailToVerify)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new UnauthorizedAccessException();
            }

            var isEmailAlreadyVerified = await _userRepository
                .IsEmailAlreadyVerifiedAsync(
                userName, 
                emailToVerify);

            var isEmailAlreadyRegistered = await _userRepository
                .IsEmailRegisteredAsync(emailToVerify);

            var alreadyHasActivationCode = await _verificationCodeRepository.HasActiveUnusedCodeAsync(userName);

            if (isEmailAlreadyVerified || isEmailAlreadyRegistered || alreadyHasActivationCode)
            {
                throw new EmailAlreadyExistsException();
            }

            // INFO: sending verification email
            var user = await _userRepository.GetByUserNameAsync(userName);
            var addedCode = await _verificationCodeRepository.AddAsync(new EmailVerificationCode()
            {
                ActivationCode = Guid.NewGuid(),
                UserId = user.Id,
                User = user,
                EmailToVerify = emailToVerify
            });
            var receiver = new EmailReceiverDTO()
            {
                ReceiverEmail = emailToVerify,
                ReceiverName = user.UserName
            };

            var body = _appSettingsOptions.Value.EmailVerifyMailOptions.BodyWithHtml.Replace(
                    "{verifyLink}",
                    _appSettingsOptions.Value.EmailVerifyMailOptions.VerificationSuccessRedirect
                    + addedCode.ActivationCode);
            try
            {
                await _emailSenderService.SendEmailAsync(
                    receiver,
                    _appSettingsOptions.Value.EmailVerifyMailOptions,
                    body,
                    _appSettingsOptions.Value.SmtpHost);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task VerifyEmailAsync(Guid activationCode)
        {
            var isCodeValidAsync = await _verificationCodeRepository
                .IsCodeValidAsync(activationCode);

            if (!isCodeValidAsync)
            {
                throw new EmailVerificationCodeException(activationCode.ToString());
            }

            await _verificationCodeRepository.UpdateCodeStateAsync(activationCode);
        }

        public async Task SendPasswordResetEmailAsync(string emailOrUserName)
        {
            var existingUser = await _userRepository.GetByEmailOrUserNameAsync(emailOrUserName);
            if (existingUser == null)
            {
                throw new NotFoundException();
            }

            if (string.IsNullOrEmpty(existingUser.Email))
            {
                throw new MissingUserEmailException();
            }

            var existingCode = await _passwordResetCodeRepository.GetUserCodeFromLastHourAsync(existingUser.Id);
            if (existingCode != null)
            {
                throw new PasswordResetAlreadySentException();
            }

            var addedCode = await _passwordResetCodeRepository.AddAsync(new PasswordResetCode()
            {
                Code = Guid.NewGuid(),
                UserId = existingUser.Id,
                User = existingUser
            });

            var emailReceiverDTO = new EmailReceiverDTO()
            {
                ReceiverEmail = existingUser.Email,
                ReceiverName = existingUser.UserName
            };

            var body = _appSettingsOptions.Value.EmailVerifyMailOptions.BodyWithHtml.Replace(
                "{verifyLink}",
                _appSettingsOptions.Value.PasswordResetMailOptions.PasswordResetSuccessRedirect
                + addedCode.Code);

            try
            {
                var isEmailSent = await _emailSenderService.SendEmailAsync(
                    emailReceiverDTO,
                    _appSettingsOptions.Value.PasswordResetMailOptions,
                    body,
                    _appSettingsOptions.Value.SmtpHost);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task<bool> CheckResetCodeAsync(Guid resetCode)
        {
            var existingCode = await _passwordResetCodeRepository.GetByUnusedCodeAsync(resetCode);
            return existingCode == null ? throw new NotFoundException() : true;
        }

        public async Task ResetPasswordAsync(ResetForgottenPasswordDTO resetForgottenPasswordDTO)
        {
            var existingCode = await _passwordResetCodeRepository.GetByUnusedCodeAsync(resetForgottenPasswordDTO.ResetCode);
            if (existingCode == null || existingCode.User == null)
            {
                throw new NotFoundException();
            }

            var newPasswordSalt = _stringEncryptorService.CreateSalt();
            var newPasswordHash = _stringEncryptorService.CreateHash(
                resetForgottenPasswordDTO.NewPassword,
                newPasswordSalt);

            existingCode.User.PasswordHash = newPasswordHash;
            existingCode.User.PasswordSalt = newPasswordSalt;

            await _userRepository.UpdateAsync(existingCode.User);

            existingCode.IsUsed = true;
            await _passwordResetCodeRepository.UpdateAsync(existingCode);
        }

        public async Task VerifyPasswordAsync(string userName, string password)
        {
            var existingUser = await _userRepository.GetByUserNameAsync(userName);     
            if (existingUser == null)
            {
                throw new NotFoundException();
            }

            var assertPasswordHash = _stringEncryptorService.CreateHash(
                password,
                existingUser.PasswordSalt);

            if (!existingUser.PasswordHash.Equals(assertPasswordHash, StringComparison.OrdinalIgnoreCase))
            {
                throw new NotFoundException();
            }
        }

        public async Task<UserNameDTO> GetUserNameByPasswordResetCodeAsync(Guid resetCodeId)
        {
            var existingUser = await _userRepository.GetByPasswordResetCodeIdAsync(resetCodeId);
            if (existingUser == null)
            {
                throw new NotFoundException();
            }

            return new UserNameDTO()
            {
                UserName = existingUser.UserName
            };
        }

        public async Task<RegisteredUserCountDTO> GetRegisteredUserCountAsync() =>
            new RegisteredUserCountDTO()
            {
                RegisteredUserCount = await _userRepository.getCountOfAllAsync()
            };

        public async Task UpdateServerPlayerStateAsync(ServerPlayerStateDTO serverPlayerStateDTO)
        {
            var gameServer = await _gameServerRepository.GetByIdAsync(serverPlayerStateDTO.GameServerId);
            if (gameServer == null)
            {
                throw new NotFoundException();
            }

            await _onlinePlayerStateRepository.AddAsync(new OnlinePlayerState()
            {
                GameServerId = gameServer.Id,
                GameServer = gameServer,
                OnlinePlayerCount = serverPlayerStateDTO.PlayerCount
            });
        }

        public async Task<OnlinePlayerCountDTO> GetOnlinePlayerCountAsync()
        {
            var serverPlayerStates = await _gameServerRepository.GetGameServerPlayerStatesAsync();
            var stateDTO = new OnlinePlayerCountDTO()
            {
                DateTime = DateTime.Now,
                PlayerCount = 0
            };

            foreach (var state in serverPlayerStates)
            {
                stateDTO.PlayerCount += state.OnlinePlayerCount;
            }
            return stateDTO;
        }

        public async Task ResetPlayerStatesAsync() =>
            await _onlinePlayerStateRepository.RemoveAllAsync();

        public async Task<ClientIdentity> GetIdentityByTokenValuesAsync(string baseValue, string encryptedValue) =>
            await _userRepository.GetIdentityByTokenValuesAsync(baseValue, encryptedValue);

        public async Task<ClientIdentity> GenerateNewClientIdentityValuesAsync(ClientIdentity clientIdentity)
        {
            var newBaseValue = _randomStringGenerator.GetRandomString(128);
            var newSalt = _randomStringGenerator.GetRandomString(64);
            var newEncryptedValue = _stringEncryptorService.CreateHash(newBaseValue, newSalt, 64);

            clientIdentity.BaseValue = newBaseValue;
            clientIdentity.ValidatorSalt = newSalt;
            clientIdentity.ValidatorHash = newEncryptedValue;

            await _clientIdentityRepository.UpdateAsync(clientIdentity);

            return clientIdentity;
        }

        public async Task<ClientIdentity> GenerateNewClientIdentityValuesAsync(string userName)
        {
            var existingUser = await _userRepository.GetByUserNameAsync(userName);

            if (existingUser == null)
            {
                throw new NotFoundException();
            }

            var newBaseValue = _randomStringGenerator.GetRandomString(128);
            var newSalt = _randomStringGenerator.GetRandomString(64);
            var newEncryptedValue = _stringEncryptorService.CreateHash(newBaseValue, newSalt, 64);

            var identity = new ClientIdentity()
            {
                BaseValue = newBaseValue,
                ValidatorSalt = newSalt,
                ValidatorHash = newEncryptedValue,
                User = existingUser,
                UserId = existingUser.Id,
                ExpirationDate = DateTime.Now.AddMinutes(60)
            };
             
            return await _clientIdentityRepository.AddOrUpdateAsync(identity);
        }

        public async Task<ClientIdentity> GetIdentityByUserNameAsync(string userName) =>
            await _clientIdentityRepository.GetIdentityByUserNameAsync(userName);

        public async Task<BannedIPListDTO> GetLastBannedIPsAsync(int banCount) =>
            _bannedIpMapper.MapToBannedIPListDTO(
                await _blacklistedIPRepository.GetLastBannedIPsAsync(banCount));

        public async Task SetIPBanStateAsync(BanStateDTO banStateDTO)
        {
            var existingBan = await _blacklistedIPRepository.GetByIPAsync(banStateDTO.IP);

            if (existingBan != null)
            {
                if (banStateDTO.IsBanned)
                {
                    existingBan.BanDate = DateTime.Now;
                    existingBan.IsIPBanned = true;
                }
                else
                {
                    existingBan.IsIPBanned = false;
                }

                await _blacklistedIPRepository.UpdateAsync(existingBan);
            }
            else
            {
                var newBan = new BlacklistedIP()
                {
                    BanDate = DateTime.Now,
                    IP = banStateDTO.IP,
                    IsIPBanned = banStateDTO.IsBanned
                };

                await _blacklistedIPRepository.AddAsync(newBan);
            }
        }

        public async Task<BannedIPDTO> GetIPInfoAsync(string IP)
        {
            var existingBan = await _blacklistedIPRepository.GetByIPAsync(IP);

            if (existingBan == null)
            {
                return null;
            }

            return new BannedIPDTO()
            {
                BanDate = existingBan.BanDate,
                IP = existingBan.IP
            };
        }

        public async Task<AggregatedOnlinePlayerCountDTOList> GetAggregatedOnlinePlayerCountAsync() =>
            _onlinePlayerCountMapper.MapToAggregatedOnlinePlayerCountDTO(
                await _onlinePlayerStateRepository.GetLastDayDataAsync());

        public async Task SendKreditGiftAsync(SendKreditGiftDTO sendKreditGiftDTO, string userName)
        {
            var existingSenderUser = await _userRepository.GetByUserNameAsync(userName);
            if (existingSenderUser == null)
            {
                throw new UnauthorizedAccessException();
            }

            var passwordHash = _stringEncryptorService.CreateHash(
                sendKreditGiftDTO.ConfirmPassword,
                existingSenderUser.PasswordSalt);

            if (!passwordHash.Equals(existingSenderUser.PasswordHash, StringComparison.OrdinalIgnoreCase))
            {
                throw new WrongPasswordException();
            }

            var existingReceiverUser = await _userRepository
                .GetByEmailOrUserNameAsync(sendKreditGiftDTO.ReceiverUserNameOrEmail);
            if (existingReceiverUser == null)
            {
                throw new NotFoundException();
            }

            if (existingReceiverUser.Id == existingSenderUser.Id)
            {
                throw new SelfKreditGiftingxception();
            }

            var absGiftKredit = Math.Abs(sendKreditGiftDTO.KreditGiftAmount);
            if (absGiftKredit < Math.Abs(_appSettingsOptions.Value.MinimumKreditGiftAmount)
                || absGiftKredit <= 0)
            {
                throw new InvalidKreditAmountException();
            }

            if (existingSenderUser.Currency < absGiftKredit)
            {
                throw new NotEnoughCurrencyException();
            }

            existingSenderUser.Currency -= absGiftKredit;
            existingReceiverUser.Currency += absGiftKredit;

            var isTransactionSucceeded = false;
            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                await _unitOfWork.UserRepository.UpdateAsync(existingSenderUser);
                await _unitOfWork.UserRepository.UpdateAsync(existingReceiverUser);

                await _unitOfWork.KreditGiftRepository.AddAsync(new KreditGift()
                {
                    KreditGiftAmount = absGiftKredit,
                    SenderUserId = existingSenderUser.Id,
                    ReceiverUserId = existingReceiverUser.Id
                });

                transaction.Commit();
                isTransactionSucceeded = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
            }

            transaction.Dispose();

            if (isTransactionSucceeded)
            {
                await _notificationService.CreateKreditGiftNotificationAsync(
                    existingSenderUser.UserName,
                    existingReceiverUser.UserName,
                    absGiftKredit);
            }
        }
    }
}
