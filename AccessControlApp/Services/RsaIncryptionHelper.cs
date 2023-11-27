using System.Security.Cryptography;
using System.Text;

namespace AccessControlApp.Services
{
    internal class RsaIncryptionHelper
    {
        public static string Encrypt(string data, string publicKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(data), true);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string Decrypt(string encryptedData, string privateKey)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(encryptedData), true);
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}
