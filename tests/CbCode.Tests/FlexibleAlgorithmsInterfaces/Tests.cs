using CbCode.Examples.FlexibleAlgorithmsInterfaces;
using NUnit.Framework;

namespace CbCode.Tests.FlexibleAlgorithmsInterfaces
{
    public class Tests
    {
        [Test]
        public void BestPriceFinder_FindsBestPrice()
        {
            var bestPriceFinder = new BestPriceFinder();
            var dealsData = new DealsData();
            var deals = new Deals(bestPriceFinder, dealsData);

            var bestDeal = deals.GetBestDeal();

            Assert.AreEqual(499.99m, bestDeal.Price);
        }

        [Test]
        public void MostDaysFinder_FindsMostDays()
        {
            var mostDaysFinder = new MostDaysFinder();
            var dealsData = new DealsData();
            var deals = new Deals(mostDaysFinder, dealsData);

            var bestDeal = deals.GetBestDeal();

            Assert.AreEqual(5, bestDeal.Days);
        }
    }
}
