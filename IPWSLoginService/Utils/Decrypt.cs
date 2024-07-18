using System.Security.Cryptography;
using System.Text;

namespace IPWSLoginService.Utils
{
    public class DecryptValue
    {
            protected static string keyString = "chatGPTRocked";

            public static string Decrypt(string encryptedString)
            {
                byte[] salt = Encoding.UTF8.GetBytes("IAMSuperSaltandSalty");
                int iterationCount = 10000;
                string decryptedText = "";

                using (var aes = Aes.Create())
                {
                    var pbkdf2 = new Rfc2898DeriveBytes(keyString, salt, iterationCount);
                    byte[] key = pbkdf2.GetBytes(32);

                    aes.Key = key;
                    aes.IV = new byte[16];

                    using (var decryptor = aes.CreateDecryptor())
                    using (var msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedString)))
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        decryptedText = srDecrypt.ReadToEnd();
                    }
                }

                return decryptedText;
            }
    }
}
