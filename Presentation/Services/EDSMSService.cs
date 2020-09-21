using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class EDSMSService : IEDSMSService
    {
        public Task<bool> ExecutePayment(PaymentTransactionDTO paymentTransactionDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
