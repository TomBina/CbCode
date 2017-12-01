using System.Collections.Generic;
using System.Net.Http;

namespace CbCode.Examples.DesignPatterns.DecoratorPattern.Before
{
    public class CacheWebPageLoader
    {
        private readonly IHttpService _httpService;
        private readonly ILogService _logService;
        private readonly Dictionary<string, string> _cache;

        public CacheWebPageLoader(IHttpService httpService, ILogService logService)
        {
            _httpService = httpService;
            _logService = logService;
            _cache = new Dictionary<string, string>();
        }

        public string Load(string url) 
            => GetFromCache(url) ?? GetFromHttp(url);

        private string GetFromHttp(string url)
        {
            string content;

            try
            {
                content = _httpService.Get(url);
            }
            catch (HttpRequestException ex)
            {
                _logService.Log(ex.Message);
                throw;
            }

            _cache[url] = content;

            return content;
        }

        private string GetFromCache(string url) 
            => _cache.ContainsKey(url) ? $"[CACHED] {_cache[url]}" : null;
    }
}