using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu
{
    public class Elado
    {
        [XmlElement(ElementName = "bank", IsNullable = true)]
        public string Bank { get; set; } = string.Empty;

        [XmlElement(ElementName = "bankszamlaszam", IsNullable = true)]
        public string Bankszamlaszam { get; set; } = string.Empty;

        [XmlElement(ElementName = "emailReplyto", IsNullable = true)]
        public string EmailReplyTo { get; set; } = string.Empty;

        [XmlElement(ElementName = "emailTargy", IsNullable = true)]
        public string EmailTargy { get; set; } = string.Empty;

        [XmlElement(ElementName = "emailSzoveg", IsNullable = true)]
        public string EmailSzoveg { get; set; } = string.Empty;
    }
}
