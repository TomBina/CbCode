using NUnit.Framework;
using System;
using System.IO;
using CbCode.Examples.FactoryMethodPattern.After;

namespace CbCode.Tests.FactoryMethodPattern.After
{
    public class Tests
    {
        [Test]
        public void FileParser_ReturnsListOf2()
        {
            var deserializerFactory = new DataDeserializerFactory();
            var parser = new FileParser(deserializerFactory);
            var directory = Path.Combine(Environment.CurrentDirectory, @"FactoryMethodPattern\Assets");

            var data = parser.Parse(directory);

            Assert.AreEqual(2, data.Count);
        }
    }
}
