using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class TetelekDTO
    {
        [XmlElement(ElementName = "tetel", IsNullable = true)]
        public Tetel[] Tetelek { get; set; }
    }
}
