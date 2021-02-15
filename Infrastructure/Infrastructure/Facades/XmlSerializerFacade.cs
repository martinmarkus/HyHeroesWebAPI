using HyHeroesWebAPI.Infrastructure.Infrastructure.Facades.Interfaces;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Facades
{
    public class XmlSerializerFacade : IXmlSerializerFacade
    {
        public string SerializeToString<T>(T obj)
            where T : class, new()
        {
            var xmlns = new XmlSerializerNamespaces();
            xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xmlns.Add("schemaLocation", "http://www.szamlazz.hu/xmlszamla https://www.szamlazz.hu/szamla/docs/xsds/agent/xmlszamla.xsd");

            var xsSubmit = new XmlSerializer(typeof(T));
            var xml = string.Empty;

            try
            {
                using (var sww = new StringWriter())
                {
                    using (var writer = XmlWriter.Create(sww))
                    {
                        xsSubmit.Serialize(writer, obj, xmlns);
                        xml = sww.ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return xml;
        }

        public ByteArrayContent SerializeToByteArray<T>(T obj)
            where T : class, new()
        {
            ByteArrayContent result = default;

            try
            {
                var serializer = new XmlSerializer(typeof(T));
                var sb = new StringBuilder();

                var xw = XmlWriter.Create(sb, new XmlWriterSettings
                {
                    Encoding = Encoding.UTF8,
                    Indent = true,
                    OmitXmlDeclaration = true,
                });

                serializer.Serialize(xw, obj);
                var bytes = Encoding.UTF8.GetBytes(sb.ToString());

                result = new ByteArrayContent(bytes);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
