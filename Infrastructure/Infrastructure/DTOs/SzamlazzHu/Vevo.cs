using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class Vevo
    {
        [XmlElement(ElementName = "nev", IsNullable = true)]
        public string Nev { get; set; } = string.Empty;

        [XmlElement(ElementName = "irsz", IsNullable = true)]
        public string Irsz { get; set; } = string.Empty;

        [XmlElement(ElementName = "telepules", IsNullable = true)]
        public string Telepules { get; set; } = string.Empty;

        [XmlElement(ElementName = "cim", IsNullable = true)]
        public string Cim { get; set; } = string.Empty;

        [XmlElement(ElementName = "email", IsNullable = true)]
        public string Email { get; set; } = string.Empty;

        [XmlElement(ElementName = "sendEmail", IsNullable = true)]
        public string SendEmail { get; set; } = string.Empty;

        [XmlElement(ElementName = "adoszam", IsNullable = true)]
        public string Adoszam { get; set; } = string.Empty;

        [XmlElement(ElementName = "postazasiNev", IsNullable = true)]
        public string PostazasiNev { get; set; } = string.Empty;

        [XmlElement(ElementName = "postazasiIrsz", IsNullable = true)]
        public string PostazasiIrsz { get; set; } = string.Empty;

        [XmlElement(ElementName = "postazasiTelepules", IsNullable = true)]
        public string PostazasiTelepules { get; set; } = string.Empty;

        [XmlElement(ElementName = "postazasiCim", IsNullable = true)]
        public string PostazasiCim { get; set; } = string.Empty;

        [XmlElement(ElementName = "azonosito", IsNullable = true)]
        public string Azonosito { get; set; } = string.Empty;

        [XmlElement(ElementName = "telefonszam", IsNullable = true)]
        public string Telefonszam { get; set; } = string.Empty;

        [XmlElement(ElementName = "megjegyzes", IsNullable = true)]
        public string Megjegyzes { get; set; } = string.Empty;
    }
}
