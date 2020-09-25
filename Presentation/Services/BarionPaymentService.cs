using BarionClientLibrary;
using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BarionPaymentService : IBarionPaymentService
    {
        private readonly BarionClient _barionClient;
        private readonly IBarionPaymentMapper _barionPaymentMapper;

        public BarionPaymentService(
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper)
        {
            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));
        }
        public async Task<bool> ExecutePayment(PaymentTransactionDTO paymentTransactionDTO)
        {
            StartPaymentOperationResult result = null;
            try
            {
                var startPayment = _barionPaymentMapper.MapToBarionPaymentDTO(paymentTransactionDTO);
                result = await _barionClient.ExecuteAsync<StartPaymentOperationResult>(startPayment);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result != null && result.IsOperationSuccessful;
        }
    }
}
