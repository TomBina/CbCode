using System.Linq;
using CbCode.Examples.DesignPatterns.StrategyPattern.Before;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.StrategyPattern.Before
{
    public class Tests
    {
        [Test]
        public void LogAnalyzer_ReturnsCorrectErrorCount()
        {
            var logAnalyzer = new LogAnalyzer(@"designpatterns\strategypattern\assets\log.json");
            var errorCount = logAnalyzer.FindErrors().Count();

            Assert.AreEqual(104, errorCount);
        }
    }
}
