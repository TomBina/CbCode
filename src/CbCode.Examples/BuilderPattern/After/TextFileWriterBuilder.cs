using System.Text;

namespace CbCode.Examples.BuilderPattern.After
{
    public class TextFileWriterBuilder
    {
        private readonly TextFileWriter _writer;

        public static TextFileWriterBuilder Create(string path)
            => new TextFileWriterBuilder(path);

        private TextFileWriterBuilder(string path)
        {
            _writer = new TextFileWriter(path);
        }

        public TextFileWriterBuilder OverwriteAllowed()
        {
            _writer.Overwrite = true;
            return this;
        }

        public TextFileWriterBuilder WithEncryption(IEncryptionService encryptionService)
        {
            _writer.EncryptionService = encryptionService;
            return this;
        }

        public TextFileWriterBuilder EncodedUsing(Encoding encoding)
        {
            _writer.Encoding = encoding;
            return this;
        }

        public TextFileWriter Build() 
            => _writer;
    }
}