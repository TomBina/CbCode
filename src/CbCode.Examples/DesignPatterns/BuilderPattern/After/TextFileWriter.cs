using System;
using System.IO;
using System.Text;

namespace CbCode.Examples.DesignPatterns.BuilderPattern.After
{
    public class TextFileWriter
    {
        public string Path { get; }
        public IEncryptionService EncryptionService { get; internal set; }
        public Encoding Encoding { get; internal set; }
        public bool Overwrite { get; internal set; }

        public TextFileWriter(string path) 
            => Path = path;

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