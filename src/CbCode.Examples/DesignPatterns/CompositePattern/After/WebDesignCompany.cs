using System.Collections.Generic;
using System.Linq;

namespace CbCode.Examples.DesignPatterns.CompositePattern.After
{
    public class WebDesignCompany : IWebDesigner
    {
        private readonly int _count;
        private readonly IEnumerable<IWebDesigner> _webDesigners;
        
        public WebDesignCompany(IEnumerable<IWebDesigner> webDesigners)
        {
            _webDesigners = webDesigners.ToList();
            _count = _webDesigners.Count();
        }

        public decimal EstimatePrice(double hours) 
            => _webDesigners.Sum(p => p.EstimatePrice(hours / _count));
    }
}