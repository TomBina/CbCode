using System;
using System.Collections.Generic;
using CbCode.Examples.StatePattern.After;
using NUnit.Framework;

namespace CbCode.Tests.StatePattern.After
{
    public class Tests
    {
        [TestCase(0, 0, 0)]
        [TestCase(0.1, 4, 0)]
        [TestCase(0.2, 9, 0)]
        [TestCase(0.3, 100, 0)]
        [TestCase(0, 100, 50)]
        public void Customer_ReturnsCorrectDiscount(decimal expectedDiscount, int orders, int daysAgo)
        {
            var lastOrderDate = DateTime.Now.AddDays(-daysAgo);
            var customer = new Customer(orders, lastOrderDate);

            var discount = customer.GetDiscount();

            Assert.AreEqual(expectedDiscount, discount);
        }
    }
}
