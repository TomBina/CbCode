using CbCode.Examples.FactoryMethodPattern.Before;

namespace CbCode.Examples.FactoryMethodPattern.After
{
    public interface IDataDeserializer
    {
        Data Deserialize(string content);
    }
}