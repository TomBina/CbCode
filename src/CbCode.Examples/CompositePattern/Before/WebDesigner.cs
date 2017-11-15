namespace CbCode.Examples.CompositePattern.Before
{
    public class WebDesigner
    {
        public string Name { get; }
        public decimal HourRate { get; }

        public WebDesigner(string name, decimal hourRate)
        {
            Name = name;
            HourRate = hourRate;
        }

        public decimal EstimatePrice(double hours)
            => (decimal) hours * HourRate;
    }
}