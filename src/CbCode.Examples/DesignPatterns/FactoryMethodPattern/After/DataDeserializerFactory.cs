using System;

namespace CbCode.Examples.DesignPatterns.FactoryMethodPattern.After
{
    public class DataDeserializerFactory
    {
        public IDataDeserializer Create(string extension)
        {
            switch (extension)
            {
                case ".json":
                    return new JsonDeserializer();
                case ".xml":
                    return new XmlDeserializer();
                default:
                    throw new InvalidOperationException("Unsupported file type");
            }
        }
    }
}