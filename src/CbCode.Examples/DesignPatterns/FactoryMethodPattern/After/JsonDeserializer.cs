using CbCode.Examples.DesignPatterns.FactoryMethodPattern.Before;
using Newtonsoft.Json;

namespace CbCode.Examples.DesignPatterns.FactoryMethodPattern.After
{
    public class JsonDeserializer : IDataDeserializer
    {
        public Data Deserialize(string content) 
            => JsonConvert.DeserializeObject<Data>(content);
    }
}