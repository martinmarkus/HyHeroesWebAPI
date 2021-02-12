using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class BankTransferMapper : IBankTransferMapper
    {
        public BankTransfer MapToBankTransfer(
            BankTransferPurchaseDTO dto, 
            int currencyValue,
            string transferCode,
            Guid userId) =>
            new BankTransfer()
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
        

        public BankTransferListDTO MapToBankTransferListDTO(IList<BankTransfer> bankTransfers)
        {
            var dto = new BankTransferListDTO();

            foreach (var bankTransfer in bankTransfers)
            {
                dto.BankTransfers.Add(MapToBankTransferDTO(bankTransfer));
            }

            return dto;
        }

        public BankTransferDTO MapToBankTransferDTO(BankTransfer bankTransfer) =>
            new BankTransferDTO()
            {
                CurrencyValue = bankTransfer.CurrencyValue,
                KreditValue = bankTransfer.KreditValue,
                StartDate = bankTransfer.CreationDate,
                TransferCode = bankTransfer.TransferCode,
                UserName = bankTransfer.User.UserName,
                IsActivated = bankTransfer.IsActivated
            };

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
