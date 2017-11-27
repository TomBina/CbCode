using CbCode.Examples.FactoryMethodPattern.Before;
using Newtonsoft.Json;

namespace CbCode.Examples.FactoryMethodPattern.After
{
    public class JsonDeserializer : IDataDeserializer
    {
        public Data Deserialize(string content) 
            => JsonConvert.DeserializeObject<Data>(content);
    }
}