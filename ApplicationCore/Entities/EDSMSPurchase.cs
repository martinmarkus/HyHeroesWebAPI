using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class EDSMSPurchase : BaseEntity
    {
        public string JatekFizetesId { get; set; }

        public string Prefix { get; set; }

        public string UserName { get; set; }

        public string ReceiverPhoneNumber { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public string GrossPrice { get; set; }

        public string IsTest { get; set; }
    }
}
