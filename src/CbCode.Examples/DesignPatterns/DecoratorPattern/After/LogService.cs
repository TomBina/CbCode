using System;

namespace CbCode.Examples.DesignPatterns.DecoratorPattern.After
{
    public class LogService : ILogService
    {
        public void Log(string message)
            => Console.WriteLine(message);
    }
}