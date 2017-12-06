using System;

namespace CbCode.Examples.DesignPatterns.StrategyPattern.Before
{
    public class LogEntry
    {
        public DateTime Date { get; }
        public string Category { get; }
        public string Message { get; }

        public LogEntry(DateTime date, string category, string message)
        {
            Date = date;
            Category = category;
            Message = message;
        }
    }
}