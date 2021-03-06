using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.BillingoDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class BillingMapper : IBillingMapper
    {
        public BillingTransaction MapToBillingTransaction(
            CreateBillingoBillDTO dto,
            bool isBilled) =>
            new BillingTransaction()
            {
                UserName = dto.UserName,
                BillingDate = DateTime.Now,
                ProductName = "Kredit",
                IsBilled = isBilled,
                Taxnumber = dto.Taxnumber,
                ClientEmail = dto.ClientEmail,
                ClientName = dto.ClientName,
                CountryCode = dto.CountryCode,
                Zip = dto.ZipCode,
                City = dto.City,
                Address = dto.Address
            };

        public BillingoPartnerDTO MapToPartnerDTO(BillingoPartner partner) =>
            new BillingoPartnerDTO()
            {
                AccountNumber = partner.AccountNumber,
                BillingoBillingAddress = partner.BillingoBillingAddress,
                BillingoBillingAddressId = partner.BillingoBillingAddressId,
                BillingoPartnerId = partner.BillingoPartnerId,
                Emails = new string[] { partner.Email },
                GeneralLedgerNumber = partner.GeneralLedgerNumber,
                Iban = partner.Iban,
                PartnerName = partner.PartnerName,
                Phone = partner.Phone,
                Swift = partner.Swift,
                Taxcode = partner.Taxcode,
                TaxType = partner.TaxType,
                UserId = partner.UserId
            };
    }
}
