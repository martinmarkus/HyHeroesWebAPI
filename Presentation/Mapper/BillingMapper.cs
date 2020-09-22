using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SzamlazzHuService.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class BillingMapper : IBillingMapper
    {
        public BillingTransaction MapToBillingTransaction(KreditPurchaseTransactionDTO kreditTransactionDTO, string email) =>
            new BillingTransaction()
            {
                UserName = kreditTransactionDTO.UserName,
                UserEmail = email,
                BillingDate = DateTime.Now,
                ProductName = "Kredit",

                VevoAdoszam = kreditTransactionDTO.VevoAdoszam,
                VevoSendEmail = kreditTransactionDTO.VevoSendEmail,
                VevoAzonosito = kreditTransactionDTO.VevoAzonosito,
                VevoEmail = kreditTransactionDTO.VevoEmail,
                VevoMegjegyzes = kreditTransactionDTO.VevoMegjegyzes,
                VevoTelefonszam = kreditTransactionDTO.VevoTelefonszam,
                VevoNev = kreditTransactionDTO.VevoNev,
                VevoIrsz = kreditTransactionDTO.VevoIrsz,
                VevoTelepules = kreditTransactionDTO.VevoTelepules,
                VevoCim = kreditTransactionDTO.VevoCim,
                VevoPostazasiNev = kreditTransactionDTO.VevoPostazasiNev,
                VevoPostazasiIrsz = kreditTransactionDTO.VevoPostazasiIrsz,
                VevoPostazasiTelepules = kreditTransactionDTO.VevoPostazasiTelepules,
                VevoPostazasiCim = kreditTransactionDTO.VevoPostazasiCim
            };
        
        public CreateBillDTO MapToCreateBillDTO(
            BillingTransaction billingTransaction,
            SellerData sellerData,
            decimal purchasedKreditPrice) =>
            new CreateBillDTO()
            {
                SzamlaAgentKulcs = sellerData.SzamlaAgentKulcs,
                SzamlaszamElotag = sellerData.SzamlaszamElotag,
                EladoBank = sellerData.EladoBank,
                EladoBankszamlaszam = sellerData.EladoBankszamlaszam,
                EladoEmailReplyTo = sellerData.EladoEmailReplyTo,
                EladoEmailSzoveg = sellerData.EladoEmailSzoveg,
                EladoEmailTargy = sellerData.EladoEmailTargy,

                VevoAdoszam = billingTransaction.VevoAdoszam,
                VevoSendEmail = billingTransaction.VevoSendEmail,
                VevoAzonosito = billingTransaction.VevoAzonosito,
                VevoEmail = billingTransaction.VevoEmail,
                VevoMegjegyzes = billingTransaction.VevoMegjegyzes,
                VevoTelefonszam = billingTransaction.VevoTelefonszam,
                VevoNev = billingTransaction.VevoNev,
                VevoIrsz = billingTransaction.VevoIrsz,
                VevoTelepules = billingTransaction.VevoTelepules,
                VevoCim = billingTransaction.VevoCim,
                VevoPostazasiNev = billingTransaction.VevoPostazasiNev,
                VevoPostazasiIrsz = billingTransaction.VevoPostazasiIrsz,
                VevoPostazasiTelepules = billingTransaction.VevoPostazasiTelepules,
                VevoPostazasiCim = billingTransaction.VevoPostazasiCim,

                Tetelek = new Tetel[1]
                {
                    new Tetel()
                    {
                        Megnevezes = billingTransaction.ProductName,
                        Mennyiseg = "1",
                        NettoEgysegar = purchasedKreditPrice.ToString(),
                        NettoErtek = purchasedKreditPrice.ToString(),
                        BruttoErtek = purchasedKreditPrice.ToString(),
                        Megjegyzes = "Virtuális tartalmakra váltható valuta."
                    }
                }
            };
    }
}
