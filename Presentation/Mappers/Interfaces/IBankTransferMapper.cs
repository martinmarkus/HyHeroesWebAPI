using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.BankTransferDTOs;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IBankTransferMapper
    {
        BankTransfer MapToBankTransfer(
            BankTransferPurchaseDTO dto,
            int currencyValue,
            string transferCode,
            Guid userId);
        BankTransferTypeListDTO MapToBankTransferPurchaseTypes(BankTransferPurchaseType[] bankTransferPurchaseTypes);
        
        BankTransferListDTO MapToBankTransferListDTO(IList<BankTransfer> lists);

        BankTransferDTO MapToBankTransferDTO(BankTransfer bankTransfer);
    }
}
