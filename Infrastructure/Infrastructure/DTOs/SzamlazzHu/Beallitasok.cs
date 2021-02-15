using System;
using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class Beallitasok
    {
        [XmlElement(ElementName = "felhasznalo", IsNullable = true)]
        public string Felhasznalo { get; set; } = String.Empty;

        [XmlElement(ElementName = "jelszo", IsNullable = true)]
        public string Jelszo { get; set; } = String.Empty;

        [XmlElement(ElementName = "szamlaagentkulcs", IsNullable = true)]
        public string SzamlaAgentKulcs { get; set; } = String.Empty;

        [XmlElement(ElementName = "eszamla", IsNullable = true)]
        public string ESzamla { get; set; } = "true";

        [XmlElement(ElementName = "szamlaLetoltes", IsNullable = true)]
        public string SzamlaLetoltes { get; set; } = "false";

        [XmlElement(ElementName = "valaszVerzio", IsNullable = true)]
        public string ValaszVerzio { get; set; } = "1";

        [XmlElement(ElementName = "aggregator", IsNullable = true)]
        public string Aggregator { get; set; } = String.Empty;
    }
}
