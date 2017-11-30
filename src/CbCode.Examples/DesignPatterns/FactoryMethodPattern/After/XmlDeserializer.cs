using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using CbCode.Examples.DesignPatterns.FactoryMethodPattern.Before;

namespace CbCode.Examples.DesignPatterns.FactoryMethodPattern.After
{
    public class XmlDeserializer : IDataDeserializer
    {
        public Data Deserialize(string content)
        {
            var dc = new DataContractSerializer(typeof(Data));

            var stringReader = new StringReader(content);
            var xmlReader = XmlReader.Create(stringReader);
            var data = (Data)dc.ReadObject(xmlReader);

            return data;
        }
    }
}