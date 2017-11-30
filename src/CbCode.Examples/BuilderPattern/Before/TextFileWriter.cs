using System;
using System.IO;
using System.Text;

namespace CbCode.Examples.BuilderPattern.Before
{
    public class TextFileWriter
    {
        public IEncryptionService EncryptionService { get; }
        public string Path { get; }
        public Encoding Encoding { get; }
        public bool Overwrite { get; }

        public TextFileWriter(string path)
        {
            Path = path;
            Encoding = Encoding.UTF8;
        }

        public TextFileWriter(string path, bool overwrite) : this(path)
        {
            Overwrite = overwrite;
        }

        public TextFileWriter(string path, bool overwrite, IEncryptionService encryptionService) : this(path, overwrite)
        {
            EncryptionService = encryptionService;
        }

        public TextFileWriter(string path, bool overwrite, IEncryptionService encryptionService, Encoding encoding) : this(path, overwrite, encryptionService)
        {
            Encoding = encoding;
        }


        public void Write(string text)
        {
            var bytes = EncryptionService != null ? Encrypt(text) : Encoding.GetBytes(text);

            Persist(bytes);
        }

        private void Persist(byte[] bytes)
        {
            if (!Overwrite && File.Exists(Path))
                throw new InvalidOperationException("Overwriting file is not allowed");

            using (var fs = File.OpenWrite(Path))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    bw.Write(bytes);
                }
            }
        }

        private byte[] Encrypt(string text) 
            => EncryptionService.Encrypt(text, Encoding);
    }
}