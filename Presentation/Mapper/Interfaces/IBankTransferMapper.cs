using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBankTransferMapper
    {
        BankTransfer MapToBankTransfer(
            BankTransferPurchaseDTO dto,
            int currencyValue,
            string transferCode,
            Guid userId);
    }
}
