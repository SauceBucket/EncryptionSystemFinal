using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace EncryptionSystem
{
    class Decryption
    {
        public byte[] DecryptFileFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)  //this is from c# documentation at https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-5.0
        {
            {
                // Check arguments.
                if (cipherText == null || cipherText.Length <= 0)
                    throw new ArgumentNullException("cipherText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                // Declare the string used to hold
                // the decrypted text.
                byte[] plaintext = null;

                // Create an Aes object
                // with the specified key and IV.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // Create a decryptor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (BinaryReader srDecrypt = new BinaryReader(csDecrypt))
                            {
                                // using (BinaryReader srDecrypt = new BinaryReader(csDecrypt))
                                //{

                                // Read the decrypted bytes from the decrypting stream
                                // and puts them in a byte array

                                srDecrypt.Read(cipherText);
                            }
                            plaintext = msDecrypt.ToArray();
                        }
                    }
                }

                return plaintext;
            }

        }
    }
}
