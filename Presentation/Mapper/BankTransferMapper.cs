using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class BankTransferMapper : IBankTransferMapper
    {
        public BankTransfer MapToBankTransfer(
            BankTransferPurchaseDTO dto, 
            int currencyValue,
            string transferCode,
            Guid userId)
        {
            return new BankTransfer()
            {
                KreditValue = dto.KreditAmount,
                CurrencyValue = currencyValue,
                IsActivated = false,
                TransferCode = transferCode,
                UserId = userId,
                TaxNumber = dto.TaxNumber,
                BillingName = dto.BillingName,
                BillingEmail = dto.BillingEmail,
                BankTransferBillingAddress = new BankTransferBillingAddress()
                {
                    City = dto.BillingCity,
                    Zip = dto.BillingZip,
                    Country = dto.BillingCountry,
                    Street = dto.BillingStreet
                }
            };
        }
    }
}
