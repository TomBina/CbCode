namespace CbCode.Examples.CompositePattern.After
{
    public class WebDesigner : IWebDesigner
    {
        public string Name { get; }
        public decimal HourRate { get; }

        public WebDesigner(string name, decimal hourRate)
        {
            Name = name;
            HourRate = hourRate;
        }

        public decimal EstimatePrice(double hours)
            => (decimal)hours * HourRate;
    }
}