namespace CbCode.Examples.ReplacingSwitchStatements.After
{
    public class JuniorSalesTargetCalculator : ISalesTargetCalculator
    {
        public int Calculate(SalesPerson salesPerson) 
            => salesPerson.PreviousSales < 10 ? 10 : 20;
    }
}