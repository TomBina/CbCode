using System.Linq;
using CbCode.Examples.DesignPatterns.CompositePattern.After;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.CompositePattern.After
{
    public class Tests
    {
        [Test]
        public void PriceTom_GreaterThan_Company()
        {
            var tom = new WebDesigner("Tom", 69.95m);
            var company = GetWebDesignCompany();

            var hours = 20d;
            var priceTom = tom.EstimatePrice(hours);
            var priceCompany = company.EstimatePrice(hours);

            // Tom's price is higher (1399.00) then the webdesign company (1099.00)
            Assert.Greater(priceTom, priceCompany);
        }

        [Test]
        public void Average()
        {
            var tom = new WebDesigner("Tom", 69.95m);
            var company = GetWebDesignCompany();

            var hours = 20d;
            var designers = new[] {tom, company};
            var average = designers.Average(d => d.EstimatePrice(hours));

            Assert.AreEqual(1249, average);
        }

        private static IWebDesigner GetWebDesignCompany()
        {
            var john = new WebDesigner("John", 49.95m);
            var jane = new WebDesigner("jane", 59.95m);

            var designers = new[] { john, jane };
            var company = new WebDesignCompany(designers);

            return company;
        }
    }
}
