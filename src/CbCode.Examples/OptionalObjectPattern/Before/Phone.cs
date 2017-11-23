namespace CbCode.Examples.OptionalObjectPattern.Before
{
    public class Phone
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Phone(int id, string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}