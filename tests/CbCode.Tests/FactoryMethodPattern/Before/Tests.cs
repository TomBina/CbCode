using CbCode.Examples.FactoryMethodPattern.Before;
using NUnit.Framework;
using System;
using System.IO;

namespace CbCode.Tests.FactoryMethodPattern.Before
{
    public class Tests
    {
        [Test]
        public void FileParser_ReturnsListOf2()
        {
            var parser = new FileParser();
            var directory = Path.Combine(Environment.CurrentDirectory, @"FactoryMethodPattern\Assets");
            var data = parser.Parse(directory);

            Assert.AreEqual(2, data.Count);
        }
    }
}

