namespace CbCode.Examples.ReplacingSwitchStatements.After
{
    public abstract class SalesPerson
    {
        public string Name { get; }
        public int PreviousSales { get; }

        protected SalesPerson(string name, int previousSales)
        {
            Name = name;
            PreviousSales = previousSales;
        }
    }
}