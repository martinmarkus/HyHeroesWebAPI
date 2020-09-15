using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class SellerData
    {
        public string PayPalCurrency { get; set; }
        public string PayPalReceiverEmail { get; set; }
        public string SzamlaAgentKulcs { get; set; }
        public string SzamlaszamElotag { get; set; }
        public string EladoBank { get; set; }
        public string EladoBankszamlaszam { get; set; }
        public string EladoEmailReplyTo { get; set; }
        public string EladoEmailSzoveg { get; set; }
        public string EladoEmailTargy { get; set; }
    }
}
