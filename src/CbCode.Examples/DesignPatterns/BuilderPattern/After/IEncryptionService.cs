using System.Text;

namespace CbCode.Examples.DesignPatterns.BuilderPattern.After
{
    public interface IEncryptionService
    {
        byte[] Encrypt(string text, Encoding encoding);
    }
}