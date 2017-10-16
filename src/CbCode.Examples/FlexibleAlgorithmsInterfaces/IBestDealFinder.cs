using System.Collections.Generic;

namespace CbCode.Examples.FlexibleAlgorithmsInterfaces
{
    public interface IBestDealFinder
    {
        Deal GetBestDeal(IEnumerable<Deal> deals);
    }
}