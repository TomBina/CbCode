using System.Collections.Generic;

namespace CbCode.Examples.StrategyPatternWithInterfaces
{
    public interface IBestDealFinder
    {
        Deal GetBestDeal(IEnumerable<Deal> deals);
    }
}