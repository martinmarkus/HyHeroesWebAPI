using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories.Interfaces;
using HyHeroesWebAPI.Presentation.Services;
using HyHeroesWebAPI.Presentation.Services.Interfaces;

namespace HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories
{
    public class PaymentServiceFactory : IPaymentServiceFactory
    {
        private readonly IEDSMSService _EDSMSService;
        private readonly IPayPalPaymentService _payPalPaymentService;
        private readonly IBarionPaymentService _barionPaymentService;

        public PaymentServiceFactory(
            IEDSMSService eDSMSService,
            IPayPalPaymentService payPalPaymentService,
            IBarionPaymentService barionPaymentService)
        {
            _EDSMSService = eDSMSService;
            _payPalPaymentService = payPalPaymentService;
            _barionPaymentService = barionPaymentService;
        }

        public IPaymentService BuildPaymentService(PaymentType paymentType)
        {
            return paymentType switch
            {
                PaymentType.EDSMS => _EDSMSService,
                PaymentType.Barion => _barionPaymentService,
                PaymentType.PayPal => _payPalPaymentService,
                _ => throw new InvalidPaymentMethodException(),
            };
        }
    }
}
