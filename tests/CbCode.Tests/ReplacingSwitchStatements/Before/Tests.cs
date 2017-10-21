using CbCode.Examples.ReplacingSwitchStatements.Before;
using NUnit.Framework;

namespace CbCode.Tests.ReplacingSwitchStatements.Before
{
    public class Tests
    {
        [Test]
        public void SalesTarget_ReturnsRightTarget()
        {
            var salesPerson = new SalesPerson("Eric", previousSales: 5, experience: Experience.Junior);
            var salesTarget = SalesTarget.CalculateSales(salesPerson);

            Assert.AreEqual(10, salesTarget);
        }
    }
}
