﻿using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IPayPalService
    {
        Task<PayPalOrderResponseDTO> CreatePayPalTransactionAsync(string authenticatedUserName, PayPalTransactionDTO payPalTransactionDTO);

        //Task VerifyPaymentsAsync(PayPalCaptureDTO payPalCaptureDTO);

        Task VerifyPaymentsAsync(string jsonBody);

        PayPalPurchaseTypeListDTO GetPayPalPurchaseTypes();
        Task<FinishedPayPalTransactionDTO> GetFinishedTransactionAsync(string orderId);
    }
}
