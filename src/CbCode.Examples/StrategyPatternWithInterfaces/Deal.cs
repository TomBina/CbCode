namespace CbCode.Examples.StrategyPatternWithInterfaces
{
    public class Deal
    {
        public string City { get; }
        public int Days { get; }
        public decimal Price { get; }

        public Deal(string city, int days, decimal price)
        {
            City = city;
            Days = days;
            Price = price;
        }
    }
}