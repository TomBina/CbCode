using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace CbCode.Examples.DesignPatterns.StrategyPattern.Before
{
    public class LogAnalyzer
    {
        private readonly string _path;

        public LogAnalyzer(string path)
        {
            _path = path;
        }

        public IEnumerable<LogEntry> FindSuccess()
        {
            var logEntries = GetLogEntries();

            return logEntries.Where(e => e.Category == "Success");
        }

        public IEnumerable<LogEntry> FindErrors()
        {
            var logEntries = GetLogEntries();

            return logEntries.Where(e => e.Category == "Error");
        }

        public IEnumerable<LogEntry> FindErrors(DateTime startDate, DateTime endDate)
        {
            var logEntries = GetLogEntries();

            return logEntries.Where(e => e.Category == "Error" && e.Date >= startDate && e.Date <= endDate);
        }

        private List<LogEntry> GetLogEntries()
        {
            var contents = File.ReadAllText(_path);
            var logEntries = JsonConvert.DeserializeObject<List<LogEntry>>(contents);
            return logEntries;
        }
    }
}