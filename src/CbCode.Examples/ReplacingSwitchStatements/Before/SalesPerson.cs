namespace CbCode.Examples.ReplacingSwitchStatements.Before
{
    public class SalesPerson
    {
        public string Name { get; }
        public int PreviousSales { get; }
        public Experience Experience { get; }

        public SalesPerson(string name, int previousSales, Experience experience)
        {
            Name = name;
            PreviousSales = previousSales;
            Experience = experience;
        }
    }
}