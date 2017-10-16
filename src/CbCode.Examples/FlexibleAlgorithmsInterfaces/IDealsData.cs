using System.Collections.Generic;

namespace CbCode.Examples.FlexibleAlgorithmsInterfaces
{
    public interface IDealsData
    {
        IEnumerable<Deal> GetAll();
    }
}