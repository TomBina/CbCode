using System.Collections.Generic;
using System.Linq;

namespace CbCode.Examples.FlexibleAlgorithmsInterfaces
{
    public class BestPriceFinder : IBestDealFinder
    {
        public Deal GetBestDeal(IEnumerable<Deal> deals) 
            => deals.OrderBy(d => d.Price).FirstOrDefault();
    }
}