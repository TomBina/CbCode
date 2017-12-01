using System.IO.Compression;
using System.Security.Cryptography;
using CbCode.Examples.DesignPatterns.DecoratorPattern.After;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.DecoratorPattern.After
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
            var webPageLoader = CreateWebPageLoader();
            var cacheWebPageLoader = new CacheWebPageLoader(webPageLoader);

            var firstResult = cacheWebPageLoader.Load("http://www.google.com");
            var secondResult = cacheWebPageLoader.Load("http://www.google.com");
            var fromCache = secondResult.StartsWith("[CACHED]");

            Assert.True(fromCache);
        }

        public IWebPageLoader CreateWebPageLoader()
        {
            var httpService = new StubHttpService();
            var logService = new LogService();
            var webPageLoader = new WebPageLoader(httpService, logService);

            return webPageLoader;
        }
    }
}
