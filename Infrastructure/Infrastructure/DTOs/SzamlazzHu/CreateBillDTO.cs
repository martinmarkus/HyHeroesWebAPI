using HyHeroesWebAPI.ApplicationCore.Enums;
using System;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class CreateBillDTO
    {
        public string SzamlaAgentKulcs { get; set; }
        public string SzamlaszamElotag { get; set; }
        public string EladoBank { get; set; }
        public string EladoBankszamlaszam { get; set; }
        public string EladoEmailReplyTo { get; set; }
        public string EladoEmailSzoveg { get; set; }
        public string EladoEmailTargy { get; set; }

        public string KeltDatum { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string TeljesitesDatum { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string FizetesiHataridoDatum { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");

        public string FizetesiMod { get; set; }

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

        public Tetel[] Tetelek { get; set; }
    }
}
