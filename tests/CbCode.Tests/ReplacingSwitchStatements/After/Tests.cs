using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.ReplacingSwitchStatements.After;
using NUnit.Framework;

namespace CbCode.Tests.ReplacingSwitchStatements.After
{
    public class Tests
    {
        [Test]
        public void JuniorSalesPerson_ReturnsRightTarget()
        {
            var salesPerson = new JuniorSalesPerson("Eric", previousSales: 5);
            var calculator = new JuniorSalesTargetCalculator();

            var salesTarget = salesPerson.CalculateSalesTarget(calculator);

            Assert.AreEqual(10, salesTarget);
        }
    }
}
