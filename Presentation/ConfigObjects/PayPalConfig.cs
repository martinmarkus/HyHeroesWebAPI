using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.ConfigObjects
{
    public class PayPalConfig
    {
        public string Client { get; set; }

        public string Secret { get; set; }

        public string PayPalAPI { get; set; }
    }
}
