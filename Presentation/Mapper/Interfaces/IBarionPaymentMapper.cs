using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Presentation.DTOs;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBarionPaymentMapper
    {
        BarionBillingAddress MapToBarionBillingAddress(BarionBillingAddressDTO addressDTO, Guid barionTransactionId);
        
        StartPaymentOperation MapToBarionPaymentDTO(BarionPaymentTransactionDTO paymentDTO);
        
        BarionTransaction MapToBarionTransaction(
            BarionPaymentTransactionDTO paymentTransactionDTO,
            StartPaymentOperationResult result,
            Guid userId,
            BarionTransactionState state);
        
        KreditPurchase MapToKreditPurchase(BarionPaymentTransactionDTO paymentTransactionDTO, Guid userId);
    }
}
