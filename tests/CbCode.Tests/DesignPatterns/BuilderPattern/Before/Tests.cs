using System.IO;
using System.Text;
using CbCode.Examples.DesignPatterns.BuilderPattern.Before;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.BuilderPattern.Before
{
    public class Tests
    {
        [Test]
        public void TextFileWriter_WritesFileToDisk()
        {
            var path = "file.txt";
            var encryptionService = new AesEncryptionService();
            var textFileWriter = new TextFileWriter(path, true, encryptionService, Encoding.Unicode);

            textFileWriter.Write("Hello world!");
            var fileExists = File.Exists(path);

            Assert.True(fileExists);
        }
    }
}
