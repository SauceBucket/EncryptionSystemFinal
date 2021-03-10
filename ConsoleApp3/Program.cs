

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Aes aesalg = Aes.Create();


            string path = "C:\\Users\\Pizza\\source\\repos\\ConsoleApp3\\ConsoleApp3\\test.txt";
            byte[] fileb;


            fileb = File.ReadAllBytes(path);
            int count = 0;

            foreach (byte b in fileb) { 
            Console.WriteLine(fileb[count]);
                count++;
            }
            Console.WriteLine("Program dead everyone clap");
            byte[] encryptedbyte = EncryptFileToBytes_Aes(fileb, aesalg.Key, aesalg.IV);
            count = 0;
            foreach (byte b in encryptedbyte)
            {
                Console.WriteLine(encryptedbyte[count]);
                count++;
            }
            using (Stream file = File.OpenWrite(@"C:\\Users\\Pizza\\source\\repos\\ConsoleApp3\\ConsoleApp3\\testencrypt.txt"))
            {
                file.Write(encryptedbyte, 0, encryptedbyte.Length);
            }
            Console.WriteLine("Program dead everyone clap");
            byte[] outputbyte = DecryptFileFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV);
            count = 0;
            
            foreach (byte b in outputbyte) {
                Console.WriteLine(outputbyte[count]);
                count++;
            }

            /*for (int i =0;i<10 ;++i)
            Console.WriteLine(encryptedbyte[i]);*/

            //string output = DecryptStringFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV);

            
            using (Stream file = File.OpenWrite(@"C:\\Users\\Pizza\\source\\repos\\ConsoleApp3\\ConsoleApp3\\testresult.txt"))
            {
                file.Write(outputbyte, 0, outputbyte.Length);
            }


                Console.WriteLine("Program dead everyone clap");
        }
        
        static byte[] EncryptFileToBytes_Aes(byte[] plainText, byte[] Key, byte[] IV)                                                                  //this is from c# documentation at https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-5.0
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (BinaryWriter swEncrypt = new BinaryWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        static byte[] DecryptFileFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)                                                                                 //this is from c# documentation at https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-5.0
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
                                // and place them in a string.

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

