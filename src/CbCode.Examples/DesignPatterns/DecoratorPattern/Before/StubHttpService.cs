namespace CbCode.Examples.DesignPatterns.DecoratorPattern.Before
{
    public class StubHttpService : IHttpService
    {
        public string Get(string url)
            => "<html><body>Some html</body></html>";
    }
}