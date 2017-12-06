using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace CbCode.Examples.DesignPatterns.StrategyPattern.After
{
    public class LogAnalyzer
    {
        private readonly string _path;

        public LogAnalyzer(string path)
        {
            _path = path;
        }

        public IEnumerable<LogEntry> Find(Func<LogEntry, bool> predicate)
        {
            var logEntries = GetLogEntries();

            return logEntries.Where(predicate);
        }

        private IEnumerable<LogEntry> GetLogEntries()
        {
            var contents = File.ReadAllText(_path);
            var logEntries = JsonConvert.DeserializeObject<List<LogEntry>>(contents);
            return logEntries;
        } 
    }
}