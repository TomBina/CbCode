using System.Collections.Generic;
using System.IO;
using CbCode.Examples.FactoryMethodPattern.Before;

namespace CbCode.Examples.FactoryMethodPattern.After
{
    public class FileParser
    {
        private readonly List<Data> _data = new List<Data>();
        private readonly DataDeserializerFactory _factory;

        public FileParser(DataDeserializerFactory factory)
        {
            _factory = factory;
        }

        public List<Data> Parse(string directory)
        {
            var files = Directory.GetFiles(directory);

            foreach (var file in files)
            {
                var fileContents = File.ReadAllText(file);
                var extension = Path.GetExtension(file);

                var deserializer = _factory.Create(extension);
                var data = deserializer.Deserialize(fileContents);

                _data.Add(data);
            }

            return _data;
        }
    }
}