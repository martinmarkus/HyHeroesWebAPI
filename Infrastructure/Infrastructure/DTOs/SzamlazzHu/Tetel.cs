using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    [XmlRoot(ElementName = "tetel", IsNullable = true)]
    public class Tetel
    {
        [XmlElement(ElementName = "megnevezes", IsNullable = true)]
        public string Megnevezes { get; set; } = string.Empty;

        [XmlElement(ElementName = "mennyiseg", IsNullable = true)]
        public string Mennyiseg { get; set; } = string.Empty;

        [XmlElement(ElementName = "mennyisegiEgyseg", IsNullable = true)]
        public string MennyisegiEgyseg { get; set; } = "db";

        [XmlElement(ElementName = "nettoEgysegar", IsNullable = true)]
        public string NettoEgysegar { get; set; } = string.Empty;

        [XmlElement(ElementName = "afakulcs", IsNullable = true)]
        public string Afakulcs { get; set; } = "AAM"; // pl 27

        [XmlElement(ElementName = "nettoErtek", IsNullable = true)]
        public string NettoErtek { get; set; } = string.Empty;

        [XmlElement(ElementName = "afaErtek", IsNullable = true)]
        public string AfaErtek { get; set; } = "0.0";

        [XmlElement(ElementName = "bruttoErtek", IsNullable = true)] // egyenlo a netto ertekkel
        public string BruttoErtek { get; set; } = string.Empty;

        [XmlElement(ElementName = "megjegyzes", IsNullable = true)]
        public string Megjegyzes { get; set; } = string.Empty;
    }
}
