using System;
using System.Linq;
using CbCode.Examples.DesignPatterns.StrategyPattern.After;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.StrategyPattern.After
{
    public class Tests
    {
        [Test]
        public void LogAnalyzer_WithFunc_ReturnsCorrectErrorCount()
        {
            var logAnalyzer = new LogAnalyzer(@"designpatterns\strategypattern\assets\log.json");
            var errorCount = logAnalyzer.Find(e => e.Category == "Error").Count();

            Assert.AreEqual(104, errorCount);
        }
    }
}

