using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingTransaction : BaseEntity
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime BillingDate { get; set; }

        public string ProductName { get; set; }

        public string VevoAdoszam { get; set; }
        public string VevoSendEmail { get; set; }
        public string VevoAzonosito { get; set; }
        public string VevoEmail { get; set; }
        public string VevoMegjegyzes { get; set; }
        public string VevoTelefonszam { get; set; }
        public string VevoNev { get; set; }
        public string VevoIrsz { get; set; }
        public string VevoTelepules { get; set; }
        public string VevoCim { get; set; }
        public string VevoPostazasiNev { get; set; }
        public string VevoPostazasiIrsz { get; set; }
        public string VevoPostazasiTelepules { get; set; }
        public string VevoPostazasiCim { get; set; }
    }
}
