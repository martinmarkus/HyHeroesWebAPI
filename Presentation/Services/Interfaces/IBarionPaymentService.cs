using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IBarionPaymentService
    {
        Task<bool> InitializeTransactionAsync(BarionPaymentTransactionDTO paymentTransactionDTO);

        Task ProcessBarionCallbackAsync(BarionCallbackDTO barionCallbackDTO);
    }
}
