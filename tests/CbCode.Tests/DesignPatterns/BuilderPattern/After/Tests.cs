using System.IO;
using System.Text;
using CbCode.Examples.DesignPatterns.BuilderPattern.After;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.BuilderPattern.After
{
    public class Tests
    {
        [Test]
        public void TextFileWriter_WritesFileToDisk()
        {
            var path = "filebuilder.txt";
            var aesEncryptionService = new AesEncryptionService();
            var textFileWriter = TextFileWriterBuilder.Create(path)
                                                      .OverwriteAllowed()
                                                      .WithEncryption(aesEncryptionService)
                                                      .EncodedUsing(Encoding.Unicode)
                                                      .Build();

            textFileWriter.Write("Hello world!");
            var fileExists = File.Exists(path);

            Assert.True(fileExists);
        }
    }
}
