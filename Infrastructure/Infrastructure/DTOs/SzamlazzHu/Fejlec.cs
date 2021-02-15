using System;
using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class Fejlec
    {
        [XmlElement(ElementName = "keltDatum", IsNullable = true)]
        public string KeltDatum { get; set; }

        [XmlElement(ElementName = "teljesitesDatum", IsNullable = true)]
        public string TeljesitesDatum { get; set; }

        [XmlElement(ElementName = "fizetesiHataridoDatum", IsNullable = true)]
        public string FizetesiHataridoDatum { get; set; }

        [XmlElement(ElementName = "fizmod", IsNullable = true)]
        public string Fizmod { get; set; }

        [XmlElement(ElementName = "penznem", IsNullable = true)]
        public string Penznem { get; set; } = "HUF";

        [XmlElement(ElementName = "szamlaNyelve", IsNullable = true)]
        public string SzamlaNyelve { get; set; } = "hu";

        [XmlElement(ElementName = "megjegyzes", IsNullable = true)]
        public string Megjegyzes { get; set; } = String.Empty;

        [XmlElement(ElementName = "arfolyamBank", IsNullable = true)]
        public string ArfolyamBank { get; set; } = "MNB";

        [XmlElement(ElementName = "arfolyam", IsNullable = true)]
        public string Arfolyam { get; set; } = "0.0";

        [XmlElement(ElementName = "rendelesSzam", IsNullable = true)]
        public string RendelesSzam { get; set; } = String.Empty;

        [XmlElement(ElementName = "dijbekeroSzamlaszam", IsNullable = true)]
        public string DijbekeroSzamlaszam { get; set; } = String.Empty;

        [XmlElement(ElementName = "elolegszamla", IsNullable = true)]
        public string Elolegszamla { get; set; } = "false";

        [XmlElement(ElementName = "vegszamla", IsNullable = true)]
        public string Vegszamla { get; set; } = "false";

        [XmlElement(ElementName = "helyesbitoszamla", IsNullable = true)]
        public string Helyesbitoszamla { get; set; } = "false";

        [XmlElement(ElementName = "helyesbitettSzamlaszam", IsNullable = true)]
        public string HelyesbitettSzamlaszam { get; set; } = String.Empty;

        [XmlElement(ElementName = "dijbekero", IsNullable = true)]
        public string Dijbekero { get; set; } = "false";

        [XmlElement(ElementName = "szamlaszamElotag", IsNullable = true)]
        public string SzamlaszamElotag { get; set; } = String.Empty;
    }
}
