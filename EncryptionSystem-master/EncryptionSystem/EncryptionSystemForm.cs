using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace EncryptionSystem
{
    public partial class EncryptionSystemForm : Form
    {
        Listener reciever = new Listener();
        Client senderino = new Client();
        Aes aesalg = Aes.Create();
        byte[] encryptedbyte;
        byte[] file;
        string path;
        public EncryptionSystemForm()
        {
            //Initializes the form and all buttons
            InitializeComponent();
        }
        public void FileSelectBtn_Click(object sender, EventArgs e)
        {
            //this just summons the file explorer with settings and then handles the filename and path
            var pathWithEnv = @"%USERPROFILE%\source\repos\EncryptionSystem-master\EncryptionSystem";             
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            openFileDialog1.InitialDirectory = filePath;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();

            path = openFileDialog1.FileName;
            file = File.ReadAllBytes(path);

            string Filename = openFileDialog1.SafeFileName;
            richTextBox1.Text = Filename;

        }
        

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            //calls the encryption function and then writes the contents to a file to verify encryption was successful
            encryptedbyte = EncryptFileToBytes_Aes(file, aesalg.Key, aesalg.IV);    
            using (Stream fileS = File.OpenWrite(@"C:\Users\richa\Desktop\Test\encrypt.file"))
            {
                fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            //calls the decryption function and then writes the contents to a file to verify decryption was successful
            byte[] outputbyte = DecryptFileFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV); 
            using (Stream fileS = File.OpenWrite(@"C:\Users\richa\Desktop\Test\goodbye.txt"))
            {
                fileS.Write(outputbyte, 0, outputbyte.Length);
            }

        }

        
        private void sendBtn_Click(object sender, EventArgs e)
        {
            senderino.Connect("24.144.139.67", file);
        }


        private void receiveBtn_Click(object sender, EventArgs e)
        {
            reciever.Recieve("192.168.0.202", @"C:\Users\richa\Desktop\Test\decrypt.file");
        }
        public void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //stub for file dialog
        }
        public static byte[] EncryptFileToBytes_Aes(byte[] plainText, byte[] Key, byte[] IV) //this is from c# documentation at https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-5.0
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


        static byte[] DecryptFileFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)  //this is from c# documentation at https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=net-5.0
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
