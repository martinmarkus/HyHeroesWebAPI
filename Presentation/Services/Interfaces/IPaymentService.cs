using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<bool> ExecutePayment(PaymentTransactionDTO paymentTransactionDTO);
    }
}
