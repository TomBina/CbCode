using System.Text;

namespace CbCode.Examples.BuilderPattern.After
{
    public interface IEncryptionService
    {
        byte[] Encrypt(string text, Encoding encoding);
    }
}