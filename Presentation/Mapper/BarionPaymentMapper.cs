using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class BarionPaymentMapper : IBarionPaymentMapper
    {
        public StartPaymentOperation MapToBarionPaymentDTO(PaymentTransactionDTO paymentTransactionDTO)
        {
            throw new NotImplementedException();
        }
    }
}
