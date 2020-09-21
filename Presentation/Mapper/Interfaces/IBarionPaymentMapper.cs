﻿using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBarionPaymentMapper
    {
        StartPaymentOperation MapToStartPaymentOperation(StartBarionPaymentDTO startBarionPaymentDTO);
    }
}
