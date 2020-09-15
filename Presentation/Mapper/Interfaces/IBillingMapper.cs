﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SzamlazzHuService.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBillingMapper
    {
        BillingTransaction MapToBillingTransaction(NewPurchasedProductDTO newPurchasedProductDTO, PurchasedProduct purchasedProduct);
        CreateBillDTO MapToCreateBillDTO(BillingTransaction billingTransaction, SellerData sellerData, PurchasedProduct purchasedProduct);
    }
}
