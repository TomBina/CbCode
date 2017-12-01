using System;

namespace CbCode.Examples.DesignPatterns.DecoratorPattern.Before
{
    public class LogService : ILogService
    {
        public void Log(string message) 
            => Console.WriteLine(message);
    }
}