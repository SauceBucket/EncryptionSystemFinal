using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

namespace EncryptionSystem
{
    class Encryption
    {
        public byte[] EncryptFileToBytes_Aes(byte[] plainText, byte[] Key, byte[] IV) //this is from c# documentation at https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-5.0
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


        //RSAEncryption is based off of code from the sources below
        // https://stackoverflow.com/questions/17128038/c-sharp-rsa-encryption-decryption-with-transmission
        // https://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/
        public byte[] RSAEncryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            // New CSP with a new 2048 bit RSA keys
            var csp = new RSACryptoServiceProvider(2048);

            // Getting private key
            var privateKey = csp.ExportParameters(true);

            // Getting public key
            var publicKey = csp.ExportParameters(false);

            // String to hold public key
            string pubkeyString;
            // Buffer
            var stringWriter = new System.IO.StringWriter();
            // Serializer
            var xSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            // Serialize key into the stream
            xSerializer.Serialize(stringWriter, publicKey);
            // Getting the key from the stream
            pubkeyString = stringWriter.ToString();

            //Converting key back
            // Get stream from string
            var stringReader = new System.IO.StringReader(pubkeyString);
            // Deserializer
            xSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            // Retrieve object from stream
            publicKey = (RSAParameters)xSerializer.Deserialize(stringReader);

            try
            {
                byte[] encryptedData; //byte to hold encrypted data
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); //import the publiic key
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding); //encrypt the byte and and DoOAEPadding
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public void EncryptAESfile(string filename, string saveloc, byte[] encryptedbyte, Aes aesalg)
        {
            //calls the encryption function and then writes the contents to a file to verify encryption was successful

            string[] temp;
            string trimmedpath = saveloc + '\\' + filename;
            temp = trimmedpath.Split('.', 2);
            trimmedpath = temp[0];

            Directory.CreateDirectory(trimmedpath);
            using (Stream fileS = File.OpenWrite(trimmedpath + "\\encrypt.file"))
            {
                fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
            }
            //saving the key and IV to files to be used later
            string x = trimmedpath + "\\key.txt";
            File.WriteAllBytes(x, aesalg.Key);

            string y = trimmedpath + "\\IV.txt";
            File.WriteAllBytes(y, aesalg.IV);

        }

        
        public void EncryptAESfolder(string[] filepaths, Aes aesalg, string folderpathSavLoc)
        {
            byte[] fileit = null;
            for (int i = 0; i < filepaths.Length; ++i)
            {
                byte[] encryptedbyte;
                string[] temp;
                string trimmedpath = filepaths[i];
                temp = trimmedpath.Split('.', 2);
                trimmedpath = temp[0];
                string file = '\\' + trimmedpath.Split('\\').Last();
                Directory.CreateDirectory(folderpathSavLoc + file);
                fileit = File.ReadAllBytes(filepaths[i]);
                encryptedbyte = EncryptFileToBytes_Aes(fileit, aesalg.Key, aesalg.IV);
                using (Stream fileS = File.OpenWrite(folderpathSavLoc + file + "\\encrypt.file"))
                {
                    fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
                }

                string x = folderpathSavLoc + file + "\\key.txt";
                File.WriteAllBytes(x, aesalg.Key);

                string y = folderpathSavLoc + file + "\\IV.txt";
                File.WriteAllBytes(y, aesalg.IV);

            }


        }

    }
}
