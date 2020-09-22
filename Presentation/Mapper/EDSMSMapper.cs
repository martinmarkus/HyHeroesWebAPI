using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class EDSMSMapper : IEDSMSMapper
    {
        public EDSMSPurchase MapToEDSMSPurchase(string id, string prefix, string message, string to, string from, string tariff, string test) =>
            new EDSMSPurchase()
            {
                JatekFizetesId = id,
                Prefix = prefix,
                UserName = message,
                ReceiverPhoneNumber = to,
                CustomerPhoneNumber = from,
                GrossPrice = tariff,
                IsTest = test
            };
    }
}
