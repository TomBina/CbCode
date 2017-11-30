using System.Text;

namespace CbCode.Examples.DesignPatterns.BuilderPattern.Before
{
    public interface IEncryptionService
    {
        byte[] Encrypt(string text, Encoding encoding);
    }
}