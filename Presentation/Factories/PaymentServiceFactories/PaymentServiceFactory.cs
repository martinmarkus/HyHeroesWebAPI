using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories.Interfaces;
using HyHeroesWebAPI.Presentation.Services;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories
{
    [Obsolete]
    public class PaymentServiceFactory : IPaymentServiceFactory
    {
        private readonly IPayPalService _payPalPaymentService;
        private readonly IBarionPaymentService _barionPaymentService;

        public PaymentServiceFactory(
            IPayPalService payPalPaymentService,
            IBarionPaymentService barionPaymentService)
        {
            _payPalPaymentService = payPalPaymentService;
            _barionPaymentService = barionPaymentService;
        }

        public IPaymentService BuildPaymentService(PaymentType paymentType)
        {
            return paymentType switch
            {
                PaymentType.Barion => _barionPaymentService,
                _ => throw new InvalidPaymentMethodException(),
            };
        }
    }
}
