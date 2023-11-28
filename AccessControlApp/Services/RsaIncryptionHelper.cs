using System.Security.Cryptography;
using System.Text;

namespace AccessControlApp.Services
{
    internal class RsaIncryptionHelper
    {
        public static void GenerateKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // Export the public and private keys
                string publicKey = rsa.ToXmlString(false); // false for public key
                string privateKey = rsa.ToXmlString(true); // true for private key

                // Save these keys securely (e.g., in a file, database, or key management system)
                File.WriteAllText("../../../publicKey.xml", publicKey);
                File.WriteAllText("../../../privateKey.xml", privateKey);
            }
        }

        public static string Encrypt(string data, string publicKey)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                byte[] encryptedData = rsa.Encrypt(dataBytes, true); // Use OAEP padding
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string Decrypt(string encryptedData, string privateKey)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                byte[] decryptedData = rsa.Decrypt(encryptedBytes, true); // Use OAEP padding
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}
