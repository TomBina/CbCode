using System.Net.Http;

namespace CbCode.Examples.DesignPatterns.DecoratorPattern.After
{
    public class WebPageLoader : IWebPageLoader
    {
        private readonly IHttpService _httpService;
        private readonly ILogService _logService;

        public WebPageLoader(IHttpService httpService, ILogService logService)
        {
            _httpService = httpService;
            _logService = logService;
        }

        public string Load(string url)
        {
            try
            {
                return _httpService.Get(url);

            }
            catch (HttpRequestException ex)
            {

                _logService.Log(ex.Message);
                throw;
            }        }
    }
}