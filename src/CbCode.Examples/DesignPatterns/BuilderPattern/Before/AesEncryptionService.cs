using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CbCode.Examples.DesignPatterns.BuilderPattern.Before
{
    public class AesEncryptionService : IEncryptionService
    {
        public byte[] Encrypt(string text, Encoding encoding)
        {
            using (var aes = Aes.Create())
            {
                var transform = aes.CreateEncryptor();

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                    {
                        using (var writer = new StreamWriter(cs, encoding))
                        {
                            writer.Write(text);
                        }
                    }

                    return ms.ToArray();
                }
            }
        }
    }
}