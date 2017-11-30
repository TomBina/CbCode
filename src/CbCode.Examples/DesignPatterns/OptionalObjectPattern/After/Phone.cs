namespace CbCode.Examples.DesignPatterns.OptionalObjectPattern.After
{
    public class Phone
    {
        public string Name { get; }
        public decimal Price { get; }

        public Phone(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}