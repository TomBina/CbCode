using CbCode.Examples.DesignPatterns.FactoryMethodPattern.Before;

namespace CbCode.Examples.DesignPatterns.FactoryMethodPattern.After
{
    public interface IDataDeserializer
    {
        Data Deserialize(string content);
    }
}