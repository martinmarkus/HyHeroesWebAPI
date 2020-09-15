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
        public BillingTransaction MapToBillingTransaction(NewPurchasedProductDTO newPurchasedProductDTO, PurchasedProduct purchasedProduct) =>
            new BillingTransaction()
            {
                UserName = purchasedProduct.User.UserName,
                UserEmail = purchasedProduct.User.Email,
                BillingDate = DateTime.Now,
                ProductName = purchasedProduct.Product.Name,

                VevoAdoszam = newPurchasedProductDTO.VevoAdoszam,
                VevoSendEmail = newPurchasedProductDTO.VevoSendEmail,
                VevoAzonosito = newPurchasedProductDTO.VevoAzonosito,
                VevoEmail = newPurchasedProductDTO.VevoEmail,
                VevoMegjegyzes = newPurchasedProductDTO.VevoMegjegyzes,
                VevoTelefonszam = newPurchasedProductDTO.VevoTelefonszam,
                VevoNev = newPurchasedProductDTO.VevoNev,
                VevoIrsz = newPurchasedProductDTO.VevoIrsz,
                VevoTelepules = newPurchasedProductDTO.VevoTelepules,
                VevoCim = newPurchasedProductDTO.VevoCim,
                VevoPostazasiNev = newPurchasedProductDTO.VevoPostazasiNev,
                VevoPostazasiIrsz = newPurchasedProductDTO.VevoPostazasiIrsz,
                VevoPostazasiTelepules = newPurchasedProductDTO.VevoPostazasiTelepules,
                VevoPostazasiCim = newPurchasedProductDTO.VevoPostazasiCim
            };
        
        public CreateBillDTO MapToCreateBillDTO(
            BillingTransaction billingTransaction,
            SellerData sellerData,
            PurchasedProduct purchasedProduct)
        {
            var priceInHuf = 
                ((purchasedProduct.IsPermanent 
                    ? purchasedProduct.Product.PermanentPrice 
                    : purchasedProduct.ValidityPeriodInMonths * purchasedProduct.Product.PricePerMonth)
                * purchasedProduct.ActualValueOfOneKredit)
                .ToString();

            return new CreateBillDTO()
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
                        NettoEgysegar = priceInHuf,
                        NettoErtek = priceInHuf,
                        BruttoErtek = priceInHuf,
                        Megjegyzes = string.Empty
                    }
                }
            };
        }    
    }
}
