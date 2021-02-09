using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.ConfigObjects;
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
                    Zip = dto.BillingZip.ToString(),
                    Country = dto.BillingCountry,
                    Street = dto.BillingStreet
                }
            };
        }

        public BankTransferTypeListDTO MapToBankTransferPurchaseTypes(
            BankTransferPurchaseType[] bankTransferPurchaseTypes)
        {
            var typeListDTO = new BankTransferTypeListDTO();

            foreach (var type in bankTransferPurchaseTypes)
            {
                typeListDTO.BankTransferPurchaseTypes.Add(new BankTransferPurchaseTypeDTO()
                {
                    GrossValue = type.GrossPrice,
                    KreditValue = type.KreditValue
                });
            }

            return typeListDTO;
        }
    }
}
