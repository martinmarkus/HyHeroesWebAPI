using System;
using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    [Serializable]
    [XmlRoot("xmlszamla", Namespace = "http://www.szamlazz.hu/xmlszamla")]
    public class SzamlazzHuBillDTO
    {
        [XmlElement(ElementName = "beallitasok", IsNullable = true)]
        public Beallitasok Beallitasok { get; set; } = new Beallitasok();

        [XmlElement(ElementName = "fejlec", IsNullable = true)]
        public Fejlec Fejlec { get; set; } = new Fejlec();

        [XmlElement(ElementName = "elado", IsNullable = true)]
        public Elado Elado { get; set; } = new Elado();

        [XmlElement(ElementName = "vevo", IsNullable = true)]
        public Vevo Vevo { get; set; } = new Vevo();

        [XmlElement(ElementName = "fuvarlevel", IsNullable = true)]
        public FuvarLevel FuvarLevel { get; set; } = new FuvarLevel();

        [XmlElement(ElementName = "tetelek", IsNullable = true)]
        public TetelekDTO Tetelek { get; set; } = new TetelekDTO();
    }
}
