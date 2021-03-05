using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.ApplicationCore.Enums
{
    public enum PayPalPaymentStatus
    {
        COMPLETED,
        DECLINED,
        PARTIALLY_REFUNDED,
        PENDING,
        REFUNDED
    }
}
