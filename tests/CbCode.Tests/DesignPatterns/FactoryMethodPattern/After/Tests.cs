using System;
using System.IO;
using CbCode.Examples.DesignPatterns.FactoryMethodPattern.After;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.FactoryMethodPattern.After
{
    public class Tests
    {
        [Test]
        public void FileParser_ReturnsListOf2()
        {
            var deserializerFactory = new DataDeserializerFactory();
            var parser = new FileParser(deserializerFactory);
            var directory = Path.Combine(Environment.CurrentDirectory, @"DesignPatterns\FactoryMethodPattern\Assets");

            var data = parser.Parse(directory);

            Assert.AreEqual(2, data.Count);
        }
    }
}
