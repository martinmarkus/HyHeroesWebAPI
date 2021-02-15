using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Mappers.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Mappers
{
    public class BillMapper : IBillMapper
    {
        public SzamlazzHuBillDTO Map(CreateBillDTO createBillDTO)
        {
            var beallitasok = new Beallitasok()
            {
                SzamlaAgentKulcs = createBillDTO.SzamlaAgentKulcs
            };

            var fejlec = new Fejlec()
            {
                Fizmod = createBillDTO.FizetesiMod,
                SzamlaszamElotag = createBillDTO.SzamlaszamElotag,
                KeltDatum = createBillDTO.KeltDatum,
                FizetesiHataridoDatum = createBillDTO.FizetesiHataridoDatum,
                TeljesitesDatum = createBillDTO.TeljesitesDatum
            };

            var elado = new Elado()
            {
                Bank = createBillDTO.EladoBank,
                Bankszamlaszam = createBillDTO.EladoBankszamlaszam,
                EmailReplyTo = createBillDTO.EladoEmailReplyTo,
                EmailSzoveg = createBillDTO.EladoEmailSzoveg,
                EmailTargy = createBillDTO.EladoEmailTargy
            };

            var vevo = new Vevo();

            if (!string.IsNullOrEmpty(createBillDTO.VevoAdoszam))
            {
                vevo.Adoszam = createBillDTO.VevoAdoszam;
            }

            vevo.SendEmail = createBillDTO.VevoSendEmail;
            vevo.Azonosito = createBillDTO.VevoAzonosito;
            vevo.Email = createBillDTO.VevoEmail;
            vevo.Megjegyzes = createBillDTO.VevoMegjegyzes;
            //vevo.Telefonszam = createBillDTO.VevoTelefonszam;

            vevo.Nev = createBillDTO.VevoNev;
            vevo.Irsz = createBillDTO.VevoIrsz;
            vevo.Telepules = createBillDTO.VevoTelepules;
            vevo.Cim = createBillDTO.VevoCim;

            //vevo.PostazasiNev = createBillDTO.VevoPostazasiNev;
            //vevo.PostazasiIrsz = createBillDTO.VevoPostazasiIrsz;
            //vevo.PostazasiTelepules = createBillDTO.VevoPostazasiTelepules;
            //vevo.PostazasiCim = createBillDTO.VevoPostazasiCim;        

            return new SzamlazzHuBillDTO()
            {
                Beallitasok = beallitasok,
                Fejlec = fejlec,
                FuvarLevel = new FuvarLevel(),
                Elado = elado,
                Vevo = vevo,
                Tetelek = new TetelekDTO()
                {
                    Tetelek = createBillDTO.Tetelek
                }
            };
        }
    }
}
