using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Presentation.Services.Interfaces;

namespace HyHeroesWebAPI.Presentation.Factories.PaymentServiceFactories.Interfaces
{
    public interface IPaymentServiceFactory
    {
        IPaymentService BuildPaymentService(PaymentType paymentType);
    }
}
