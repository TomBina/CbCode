using System.Collections.Generic;
using System.Linq;

namespace CbCode.Examples.FlexibleAlgorithmsInterfaces
{
    public class MostDaysFinder : IBestDealFinder
    {
        public Deal GetBestDeal(IEnumerable<Deal> deals) 
            => deals.OrderByDescending(d => d.Days).ThenBy(d => d.Price).FirstOrDefault();
    }
}