namespace CbCode.Examples.ReplacingSwitchStatements.After
{
    public class JuniorSalesPerson : SalesPerson
    {
        public JuniorSalesPerson(string name, int previousSales) : base(name, previousSales) { }

        public int CalculateSalesTarget(ISalesTargetCalculator calculator) 
            => calculator.Calculate(this);
    }
}