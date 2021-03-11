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
        Aes aesalg = Aes.Create();

        

        public EncryptionSystemForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
       
            string path = "C:\\Users\\Schyguy\\Documents\\CPSC488\\files\\test.txt";
            byte[] fileb;

            fileb = File.ReadAllBytes(path);
            int count = 0;

            foreach (byte b in fileb)
            {
                //Console.WriteLine(fileb[count]);
                count++;
            }
            
            byte[] encryptedbyte = EncryptFileToBytes_Aes(fileb, aesalg.Key, aesalg.IV);
            count = 0;
            foreach (byte b in encryptedbyte)
            {
                //Console.WriteLine(encryptedbyte[count]);
                count++;
            }
            using (Stream file = File.OpenWrite(@"C:\\Users\\Schyguy\\Documents\\CPSC488\\files\\test.txt"))
            {
                file.Write(encryptedbyte, 0, encryptedbyte.Length);
            }

            using (Stream file = File.OpenWrite(@"C:\\Users\\Schyguy\\Documents\\CPSC488\\files\\testencrypt.txt"))
            {
                file.Write(encryptedbyte, 0, encryptedbyte.Length);
            }


            byte[] outputbyte = DecryptFileFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV);
            count = 0;

            foreach (byte b in outputbyte)
            {
                Console.WriteLine(outputbyte[count]);
                count++;
            }

            /*for (int i =0;i<10 ;++i)
            Console.WriteLine(encryptedbyte[i]);*/

            //string output = DecryptStringFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV);


            using (Stream file = File.OpenWrite(@"C:\\Users\\Schyguy\\Documents\\CPSC488\\files\\test.txt"))
            {
                file.Write(outputbyte, 0, outputbyte.Length);
            }


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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            

            string path = "C:\\Users\\Schyguy\\Documents\\CPSC488\\files\\test.txt";
            byte[] filec;

            filec = File.ReadAllBytes(path);
            int count = 0;

            byte[] outputbyte = DecryptFileFromBytes_Aes(filec, aesalg.Key, aesalg.IV);
            count = 0;

            foreach (byte b in outputbyte)
            {
                Console.WriteLine(outputbyte[count]);
                count++;
            }

            /*for (int i =0;i<10 ;++i)
            Console.WriteLine(encryptedbyte[i]);*/

            //string output = DecryptStringFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV);


            using (Stream file = File.OpenWrite(@"C:\\Users\\Schyguy\\Documents\\CPSC488\\files\\test.txt"))
            {
                file.Write(outputbyte, 0, outputbyte.Length);
            }

        }

        Client senderino = new Client();
        private void sendBtn_Click(object sender, EventArgs e)
        {
            senderino.Connect("73.214.77.177", @"C:\Users\Schyguy\Documents\CSC488\files\test.txt");
            MessageBox.Show("Sent.");
        }

        Listener reciever = new Listener();
        private void receiveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connecting....");
            reciever.Recieve("192.168.0.19", @"C:\Users\Schyguy\Downloads\ProjectTesting\received.txt");
            MessageBox.Show("Received");
        }
    }
}
