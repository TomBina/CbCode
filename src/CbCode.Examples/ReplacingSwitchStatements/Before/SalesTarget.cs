using System;

namespace CbCode.Examples.ReplacingSwitchStatements.Before
{
    public static class SalesTarget
    {
        public static int CalculateSales(SalesPerson salesPerson)
        {
            switch (salesPerson.Experience)
            {
                case Experience.Junior:
                    if (salesPerson.PreviousSales < 10)
                        return 10;
                    else
                        return 20;
                case Experience.Medior:
                    if (salesPerson.PreviousSales < 20)
                        return 20;
                    else
                        return 30;
                case Experience.Senior:
                    if (salesPerson.PreviousSales < 30)
                        return 30;
                    else
                        return 40;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}