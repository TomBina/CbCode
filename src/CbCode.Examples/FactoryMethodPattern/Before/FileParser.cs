using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace CbCode.Examples.FactoryMethodPattern.Before
{
    public class FileParser
    {
        private readonly List<Data> _data = new List<Data>();

        public List<Data> Parse(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var file in files)
            {
                var fileContents = File.ReadAllText(file);
                var extension = Path.GetExtension(file);

                switch (extension)
                {
                    case ".xml":
                        _data.Add(ParseXml(fileContents));
                        break;
                    default:
                        _data.Add(ParseJson(fileContents));
                        break;
                }
            }

            return _data;
        }

        private Data ParseXml(string content)
        {
            var dc = new DataContractSerializer(typeof(Data));

            var stringReader = new StringReader(content);
            var xmlReader = XmlReader.Create(stringReader);
            var data = (Data)dc.ReadObject(xmlReader);

            return data;
        }

        private Data ParseJson(string content)
        {
            var data = JsonConvert.DeserializeObject<Data>(content);

            return data;
        }
    }
}