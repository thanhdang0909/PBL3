using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DTO
{
    class Convert_Password
    {
        //Mã hóa
        public static string Encode(string password)
        {
            byte[] key = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };
            byte[] iv = { 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10, 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };

            using (AesManaged aes = new AesManaged())
            {
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream output = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(output, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] input = Encoding.UTF8.GetBytes(password);
                        cs.Write(input, 0, input.Length);
                        cs.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(output.ToArray());
                }
            }
        }
        //Giải mã
        public static string Decode(string password)
        {
            try
            {
                byte[] key = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 };
                byte[] iv = { 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10, 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };

                using (AesManaged aes = new AesManaged())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    byte[] input = Convert.FromBase64String(password);
                    using (MemoryStream output = new MemoryStream(input))
                    {
                        using (CryptoStream cs = new CryptoStream(output, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            byte[] decryptedBytes = new byte[input.Length];
                            cs.Read(decryptedBytes, 0, decryptedBytes.Length);
                            return Encoding.UTF8.GetString(decryptedBytes);
                        }
                    }
                }
            }
            catch (FormatException)
            { 
                return null;
            }
        }


    }
}
