using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.BarionDTOs;
using System;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
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
        
        BarionPurchaseTypeListDTO MapToBarionPurchaseTypeListDTO(BarionPurchaseType[] barionPurchaseTypes);

        KreditPurchase MapToKreditPurchase(BarionTransaction barionTransaction);
    }
}
