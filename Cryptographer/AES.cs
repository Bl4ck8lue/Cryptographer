using System.Security.Cryptography;
using System.IO;


namespace Cryptographer
{
    public class AES
    {
        private Aes aes = Aes.Create();
        public AES()
        {
            aes.GenerateKey();
            aes.GenerateIV();
        }
        public byte[] Encrypt(string file_name)
        {
            byte[] Basic_bytes = File.ReadAllBytes(file_name);
            byte[] Encrypt_bytes = aes.CreateEncryptor().TransformFinalBlock(Basic_bytes, 0, Basic_bytes.Length);
            return Encrypt_bytes;
        }
        public byte[] Decrypt(string file_name)
        {
            byte[] Basic_bytes = File.ReadAllBytes(file_name);
            byte[] Decrypt_bytes = aes.CreateDecryptor().TransformFinalBlock(Basic_bytes, 0, Basic_bytes.Length);
            return Decrypt_bytes;
        }
    }
}
