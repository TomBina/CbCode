using System.Collections.Generic;

namespace CbCode.Examples.FlexibleAlgorithmsInterfaces
{
    public class Deals
    {
        private readonly IBestDealFinder _bestDealFinder;
        private readonly IEnumerable<Deal> _deals;

        public Deals(IBestDealFinder bestDealFinder, IDealsData dealsData)
        {
            _bestDealFinder = bestDealFinder;
            _deals = dealsData.GetAll();
        }

        public Deal GetBestDeal() 
            => _bestDealFinder.GetBestDeal(_deals);
    }
}