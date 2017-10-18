using System.Collections.Generic;

namespace CbCode.Examples.StrategyPatternWithInterfaces
{
    public class DealsData : IDealsData
    {
        private readonly List<Deal> _deals;

        public DealsData()
        {
            _deals = new List<Deal>()
            {
                new Deal("New York", days: 5, price: 599.99m),
                new Deal("Las Vegas", days: 4, price: 499.99m)
            };
        }

        public IEnumerable<Deal> GetAll() => _deals;
    }
}