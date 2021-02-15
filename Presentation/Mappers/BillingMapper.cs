using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System;

namespace HyHeroesWebAPI.Presentation.Mappers
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
            SzamlazzHuConfig szamlazzHuConfig,
            decimal purchasedKreditPrice,
            int purchasedKreditValue,
            PaymentType paymentType)
        {
            var value = Convert.ToInt32(purchasedKreditPrice).ToString();

            var paymentTypeString = string.Empty;
            switch (paymentType)
            {
                case PaymentType.BankTransfer:
                    paymentTypeString = "Banki utalás";
                    break;
                case PaymentType.Barion:
                    paymentTypeString = "Online bankkártyás fizetés (Barion)";
                    break;
                case PaymentType.PayPal:
                    paymentTypeString = "Online fizetés (PayPal)";
                    break;
            }

            return new CreateBillDTO()
            {
                FizetesiMod = paymentTypeString,

                SzamlaAgentKulcs = szamlazzHuConfig.SzamlaAgentKulcs,
                SzamlaszamElotag = szamlazzHuConfig.SzamlaszamElotag,
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
                        Megnevezes = purchasedKreditValue + " " + billingTransaction.ProductName,
                        Mennyiseg = "1",
                        NettoEgysegar = value,
                        NettoErtek = value,
                        BruttoErtek = value,
                        Megjegyzes = "Virtuális tartalmakra váltható valuta."
                    }
                }
            };
        }
    }
}
