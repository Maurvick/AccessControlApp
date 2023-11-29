using System.Security.Cryptography;
using System.Text;

namespace AccessControlApp.Services
{
    internal class RSAIncryptionHelper
    {
        public const string RSA_PRIVATE_KEY_PATH = "privateKey.xml";
        public const string RSA_PUBLIC_KEY_PATH = "publicKey.xml";

        public static void ReadKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                try 
                {
                    rsa.FromXmlString(RSA_PUBLIC_KEY_PATH);
                    rsa.FromXmlString(RSA_PRIVATE_KEY_PATH);
                }
                catch (CryptographicException)
                {
                    MessageBox.Show($"Ключі шифрування не знайдені. Згенеровані нові ключи.");

                    GenerateKeys();
                }
            } 
        }

        private static void GenerateKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                // export parameters to file
                var parameters = rsa.ExportParameters(true);

                // Export the public and private keys
                string publicKey = rsa.ToXmlString(false); // false for public key
                string privateKey = rsa.ToXmlString(true); // true for private key
                
                // Save private and public keys separately
                File.WriteAllText(RSA_PRIVATE_KEY_PATH, privateKey);
                File.WriteAllText(RSA_PUBLIC_KEY_PATH, publicKey);
            }
        }

        public static string Encrypt(string dataToEncrypt)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(dataToEncrypt);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(RSA_PUBLIC_KEY_PATH);
                byte[] encryptedData = rsa.Encrypt(dataBytes, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string Decrypt(string encryptedData)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(RSA_PRIVATE_KEY_PATH);
                byte[] decryptedData = rsa.Decrypt(encryptedBytes, false); 
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}
