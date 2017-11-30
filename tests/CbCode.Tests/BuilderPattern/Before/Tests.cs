using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CbCode.Examples.BuilderPattern.Before;
using NUnit.Framework;

namespace CbCode.Tests.BuilderPattern.Before
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
