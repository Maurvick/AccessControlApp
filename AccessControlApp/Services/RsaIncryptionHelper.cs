using System.Security.Cryptography;
using System.Text;

namespace AccessControlApp.Services
{
    internal class RSAIncryptionHelper
    {
        public const string RSA_PUBLIC_KEY_PATH = "publicKey.xml";
        public const string RSA_PRIVATE_KEY_PATH = "privateKey.xml";
        // Keep same rsa key, to avoid key errors
        public const int RSA_Key_Size = 2048;

        private readonly static string publicKey = File.ReadAllText("publicKey.xml");
        private readonly static string privateKey = File.ReadAllText("privateKey.xml");

        public static void ReadKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(RSA_Key_Size))
            {
                try 
                {
                    // Check if keys is valid
                    rsa.FromXmlString(publicKey);
                    rsa.FromXmlString(privateKey);
                }
                catch (CryptographicException)
                {
                    // Create new RSA keys, which means old keys will fail to decrypt old entries.
                    MessageBox.Show($"Ключі шифрування не знайдені. Згенеровані нові ключи.");

                    GenerateKeys();
                }
            } 
        }

        private static void GenerateKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(RSA_Key_Size))
            {
                // Export the public and private keys
                string publicKey = rsa.ToXmlString(false); // false for public key
                string privateKey = rsa.ToXmlString(true); // true for private key

                // Save these keys securely (e.g., in a file, database, or key management system)
                File.WriteAllText(RSA_PUBLIC_KEY_PATH, publicKey);
                File.WriteAllText(RSA_PRIVATE_KEY_PATH, privateKey);
            }
        }

        // TODO: Handle expired RSA key error
        public static string Encrypt(string dataToEncrypt)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(dataToEncrypt);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(RSA_Key_Size))
            {
                rsa.FromXmlString(publicKey);
                byte[] encryptedData = rsa.Encrypt(dataBytes, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string Decrypt(string encryptedData)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(RSA_Key_Size))
            {
                rsa.FromXmlString(privateKey);
                byte[] decryptedData = rsa.Decrypt(encryptedBytes, false); 
                return Encoding.UTF8.GetString(decryptedData);
            }
        }
    }
}
