using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalPaymentService : IPayPalPaymentService
    {
        public Task<bool> ExecutePayment(PaymentTransactionDTO paymentTransactionDTO)
        {
            throw new NotImplementedException();
        }
    }
}
