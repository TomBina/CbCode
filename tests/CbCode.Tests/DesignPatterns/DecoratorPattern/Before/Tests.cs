using CbCode.Examples.DesignPatterns.DecoratorPattern.Before;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CbCode.Tests.DesignPatterns.DecoratorPattern.Before
{
    public class Tests
    {
        [Test]
        public void WebPageLoader_ReturnsHtml()
        {
            var httpService = new StubHttpService();
            var logService = new LogService();
            var webPageLoader = new WebPageLoader(httpService, logService);

            var html = webPageLoader.Load("http://www.google.com");

            Assert.NotNull(html);
        }

        [Test]
        public void CacheWebPageLoader_ReturnsHtmlFromCache()
        {
            var httpService = new StubHttpService();
            var logService = new LogService();
            var cacheWebPageLoader = new CacheWebPageLoader(httpService, logService);

            var firstResult = cacheWebPageLoader.Load("http://www.google.com");
            var secondResult = cacheWebPageLoader.Load("http://www.google.com");
            var fromCache = secondResult.StartsWith("[CACHED]");

            Assert.True(fromCache);
        }

    }
}
