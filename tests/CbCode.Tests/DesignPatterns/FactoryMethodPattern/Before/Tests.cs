using System;
using System.IO;
using CbCode.Examples.DesignPatterns.FactoryMethodPattern.Before;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.FactoryMethodPattern.Before
{
    public class Tests
    {
        [Test]
        public void FileParser_ReturnsListOf2()
        {
            var parser = new FileParser();
            var directory = Path.Combine(Environment.CurrentDirectory, @"DesignPatterns\FactoryMethodPattern\Assets");
            var data = parser.Parse(directory);

            Assert.AreEqual(2, data.Count);
        }
    }
}

