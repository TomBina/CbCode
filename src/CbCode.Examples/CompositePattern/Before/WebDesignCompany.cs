using System.Collections.Generic;

namespace CbCode.Examples.CompositePattern.Before
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