using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using CbCode.Examples.FactoryMethodPattern.Before;

namespace CbCode.Examples.FactoryMethodPattern.After
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