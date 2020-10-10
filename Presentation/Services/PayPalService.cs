using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Security;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalService : IPayPalService
    {
        private readonly IPayPalTransactionRequestRepository _payPalTransactionRequestRepository;
        private readonly IPayPalIPNMessageRepository _payPalIPNMessageRepository;
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IUserRepository _userRepository;

        private readonly IPayPalMapper _payPalMapper;

        public PayPalService(
            IPayPalTransactionRequestRepository payPalTransactionRequestRepository,
            IPayPalIPNMessageRepository payPalIPNMessageRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IUserRepository userRepository,
            IPayPalMapper payPalMapper)
        {
            _payPalTransactionRequestRepository = payPalTransactionRequestRepository ?? throw new ArgumentException(nameof(payPalTransactionRequestRepository));
            _payPalIPNMessageRepository = payPalIPNMessageRepository ?? throw new ArgumentException(nameof(payPalIPNMessageRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));

            _payPalMapper = payPalMapper ?? throw new ArgumentException(nameof(payPalMapper));
        }


        public async Task<PayPalTransactionDTO> CreatePayPalTransaction(string authenticatedUserName)
        {
            var user = await _userRepository.GetByUserNameAsync(authenticatedUserName);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            var addedPayPalTransaction = await _payPalTransactionRequestRepository.AddAsync(
                new PayPalTransactionRequest()
                {
                    IsRequestProcessed = false,
                    TimeStamp = DateTime.Now,
                    RequesterUserId = user.Id,
                    RequesterUser = user
                });

            return new PayPalTransactionDTO()
            {
                TransactionId = addedPayPalTransaction.Id
            };
        }

        public async Task<bool> ProcessIPNMessageAsync(PayPalIPNMessage newIPNMessage)
        {
            await _payPalIPNMessageRepository.AddAsync(newIPNMessage);

            //var isIPNValid =  await IsIPNValidAsync(newIPNMessage);

            //if (isIPNValid)
            //{
            //    await _payPalIPNMessageRepository.AddAsync(newIPNMessage);

            //    // TODO: kredit hozzáadása
            //    var kreditRatio = await _purchasedProductRepository.GetActualValueOfOneKreditAsync();
            //    var valueToAdd = newIPNMessage.PaymentGross / kreditRatio.Value;

            //}

            return true;
        }

        private async Task<bool> IsIPNValidAsync(PayPalIPNMessage ipnMessage)
        {
            // INFO: Custom Transcation Id check:
            var isGuid = Guid.TryParse(ipnMessage.Custom, out Guid transactionId);

            if (!isGuid)
            {
                return false;
            }
            
            var payPalTransaction = await _payPalTransactionRequestRepository.GetByIdAsync(transactionId);
            
            if (payPalTransaction == null 
                || transactionId != payPalTransaction.Id 
                || payPalTransaction.IsRequestProcessed
                || payPalTransaction.TimeStamp.AddMinutes(60) < DateTime.Now)
            {
                return false;
            }

            // INFO at this point the custom id is valid




            // TODO: implement
            return true;
        }
    }
}
