using System.Security.Cryptography;

namespace AccessControlApp.Services
{
    internal class RsaKeyGenerator
    {
        public static void GenerateKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Export the public and private keys
                string publicKey = rsa.ToXmlString(false); // false for public key
                string privateKey = rsa.ToXmlString(true); // true for private key

                // Save these keys securely (e.g., in a file, database, or key management system)
                File.WriteAllText("publicKey.xml", publicKey);
                File.WriteAllText("privateKey.xml", privateKey);
            }
        }
    }
}
