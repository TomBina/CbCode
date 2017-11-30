using System.Collections.Generic;

namespace CbCode.Examples.DesignPatterns.CompositePattern.Before
{
    public class WebDesignCompany
    {
        public IEnumerable<WebDesigner> WebDesigners { get; }

        public WebDesignCompany(IEnumerable<WebDesigner> webDesigners)
        {
            WebDesigners = webDesigners;
        }
    }
}