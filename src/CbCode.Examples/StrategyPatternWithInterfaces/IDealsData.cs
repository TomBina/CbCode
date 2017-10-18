using System.Collections.Generic;

namespace CbCode.Examples.StrategyPatternWithInterfaces
{
    public interface IDealsData
    {
        IEnumerable<Deal> GetAll();
    }
}