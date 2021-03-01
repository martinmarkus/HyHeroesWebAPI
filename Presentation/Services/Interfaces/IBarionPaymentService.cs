﻿using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IBarionPaymentService
    {
        Task<InitializedBarionTransactionDTO> InitializeTransactionAsync(string userName, BarionPaymentTransactionDTO paymentTransactionDTO);

        Task ProcessBarionCallbackAsync(string paymentId);

        BarionPurchaseTypeListDTO GetBarionPurchaseTypes();

        Task<BarionTransactionStateDTO> CheckBarionPaymentIdAsync(string paymentId);
    }
}
