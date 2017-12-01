using System.Net.Http;

namespace CbCode.Examples.DesignPatterns.DecoratorPattern.Before
{
    public class WebPageLoader
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