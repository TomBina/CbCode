namespace CbCode.Examples.DesignPatterns.ChainOfResponsibility.Before
{
    public class Link
    {
        public string Name { get; }
        public string Url { get; }

        public Link(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}