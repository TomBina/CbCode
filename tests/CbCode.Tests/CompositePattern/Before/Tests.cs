using System;
using System.Linq;
using CbCode.Examples.CompositePattern.Before;
using NUnit.Framework;

namespace CbCode.Tests.CompositePattern.Before
{
    public class Tests
    {
        [Test]
        public void PriceTom_GreaterThan_Company()
        {
            var tom = new WebDesigner("Tom", 69.95m);
            var company = CreateWebDesignCompany();

            var estimatedHours = 20d;
            var priceTom = tom.EstimatePrice(estimatedHours);
            var priceCompany = company.WebDesigners.Sum(p =>
            {
                var totalDesigners = company.WebDesigners.Count();
                return p.EstimatePrice(estimatedHours / totalDesigners);
            });

            // Tom's price is higher (1399.00) then the webdesign company (1099.00)
            Assert.Greater(priceTom, priceCompany);
        }

        [Test]
        public void AveragePrice()
        {
            var tom = new WebDesigner("Tom", 69.95m);
            var company = CreateWebDesignCompany();

            var estimatedHours = 20d;
            var priceTom = tom.EstimatePrice(estimatedHours);
            var priceCompany = company.WebDesigners.Sum(p =>
            {
                var totalDesigners = company.WebDesigners.Count();
                return p.EstimatePrice(estimatedHours / totalDesigners);
            });
            var average = (priceTom + priceCompany) / 2;

            Assert.AreEqual(1249, average);
        }

        private static WebDesignCompany CreateWebDesignCompany()
        {
            var john = new WebDesigner("John", 49.95m);
            var jane = new WebDesigner("jane", 59.95m);

            var designers = new[] {john, jane};
            var company = new WebDesignCompany(designers);

            return company;
        }
    }
}