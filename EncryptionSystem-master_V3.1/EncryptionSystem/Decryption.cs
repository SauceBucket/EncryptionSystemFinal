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


        //RSADecryption is based off of code from the sources below
        // https://stackoverflow.com/questions/17128038/c-sharp-rsa-encryption-decryption-with-transmission
        // https://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/
        public byte[] RSADecryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {

            try
            {
                // Byte to put decrypted data into
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //import private key for decryption
                    RSA.ImportParameters(RSAKey);

                    //decrypt file
                    decryptedData = RSA.Decrypt(Data, false);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                return null;
            }
        }
    
        public void DecryptFolderAES(string path, string folderpathSavLoc)
        {
            byte[] file = File.ReadAllBytes(path + "\\encrypt.file");
            byte[] IV = File.ReadAllBytes(path + "\\IV.txt");
            byte[] key = File.ReadAllBytes(path + "\\key.txt");
            //calls the decryption function and then writes the contents to a file to verify decryption was successful
            byte[] outputbyte = DecryptFileFromBytes_Aes(file, key, IV);
            using (Stream fileS = File.OpenWrite(folderpathSavLoc + "\\decrypted.file"))
            {
                fileS.Write(outputbyte, 0, outputbyte.Length);
            }

        }

        public void DecryptFolderRSA(string path, string folderpathSavLoc)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            byte[] file = File.ReadAllBytes(path + "\\encrypt.file");
            byte[] key = File.ReadAllBytes(path + "\\key.txt");
            string privkeyString = Encoding.Default.GetString(key); //get private key as a string
            RSAParameters privKey; //Placeholder for private key

            var sr = new StringReader(privkeyString); // Get stream from string
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters)); //Deserializing 
            privKey = (RSAParameters)xs.Deserialize(sr); // Get object from stream

            RSA.ImportParameters(privKey);
            byte[] outputbyte = RSADecryption(file, privKey, false);
        }
        public void DecryptZip(string saveloc,string cryptoType,string filepath,RSA RSA) {
            string trimmedpath = saveloc;
            System.IO.Compression.ZipFile.ExtractToDirectory(filepath, trimmedpath);
            String[] temp = Directory.GetDirectories(trimmedpath);
            String[] folderpaths = Directory.GetDirectories(temp[0]);
            foreach (string x in folderpaths)
            {
                if (cryptoType == "AES")
                {

                    string path = x;
                    byte[] file = File.ReadAllBytes(path + "\\encrypt.file");
                    byte[] IV = File.ReadAllBytes(path + "\\IV.txt");
                    byte[] key = File.ReadAllBytes(path + "\\key.txt");
                    //calls the decryption function and then writes the contents to a file to verify decryption was successful
                    byte[] outputbyte = DecryptFileFromBytes_Aes(file, key, IV);
                    using (Stream fileS = File.OpenWrite(path + "\\decrypted.file"))
                    {
                        fileS.Write(outputbyte, 0, outputbyte.Length);
                    }

                }
                else if (cryptoType == "RSA")
                {
                    string path = x;
                    byte[] encryptedbyte = File.ReadAllBytes(path + "\\encrypt.file");
                    byte[] key = File.ReadAllBytes(path + "\\key.txt");

                    string privkeyString = Encoding.Default.GetString(key); //get private key as a string
                    RSAParameters privKey; //Placeholder for private key

                    var sr = new StringReader(privkeyString); // Get stream from string
                    var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters)); //Deserializing 
                    privKey = (RSAParameters)xs.Deserialize(sr); // Get object from stream

                    RSA.ImportParameters(privKey);

                    byte[] decryptedbyte = RSADecryption(encryptedbyte, privKey, false);
                    if (decryptedbyte != null)
                    {
                        using (Stream fileS = File.OpenWrite(path + "\\decrypted.file"))
                        {
                            fileS.Write(decryptedbyte, 0, decryptedbyte.Length);
                        }
                    }
                    else
                    {
                        Exception e = new Exception();
                        throw e;
                        {

                        }
                    }

                }
            }
        }
    }
}