using System.Collections.Generic;

namespace CbCode.Examples.DesignPatterns.DecoratorPattern.After
{
    public class CacheWebPageLoader : IWebPageLoader
    {
        private readonly IWebPageLoader _webPageLoader;
        private readonly Dictionary<string, string> _cache;

        public CacheWebPageLoader(IWebPageLoader webPageLoader)
        {
            _webPageLoader = webPageLoader;
            _cache = new Dictionary<string, string>();
        }

        public string Load(string url)
            => GetFromCache(url) ?? GetFromHttp(url);

        private string GetFromHttp(string url)
        {
            var content = _webPageLoader.Load(url);
            _cache[url] = content;
            return content;
        }

        private string GetFromCache(string url)
            => _cache.ContainsKey(url) ? $"[CACHED] {_cache[url]}" : null;
    }
}