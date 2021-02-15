using System;
using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class FuvarLevel
    {
        [XmlElement(ElementName = "uticel", IsNullable = true)]
        public string Uticel { get; set; } = String.Empty;

        [XmlElement(ElementName = "futarSzolgalat", IsNullable = true)]
        public string FutarSzolgalat { get; set; } = String.Empty;
    }
}
