using System.Text;

namespace CbCode.Examples.BuilderPattern.Before
{
    public interface IEncryptionService
    {
        byte[] Encrypt(string text, Encoding encoding);
    }
}