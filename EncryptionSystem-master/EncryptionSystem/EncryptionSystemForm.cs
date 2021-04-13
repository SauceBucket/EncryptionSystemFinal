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
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] encryptedbyte;
        byte[] file;
        byte[] key;
        byte[] IV;
        string path;
        public EncryptionSystemForm()
        {
            //Initializes the form and all buttons
            InitializeComponent();
        }
      
        //Main Buttons (Encrypt, Decrypt, Send, Receive)

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            Encryption tempByte = new Encryption();

            if (echoiceBox.SelectedItem.ToString() == "AES")
            {

                //calls the encryption function and then writes the contents to a file to verify encryption was successful
                encryptedbyte = tempByte.EncryptFileToBytes_Aes(file, aesalg.Key, aesalg.IV);
                using (Stream fileS = File.OpenWrite(textBox2.Text + "\\encrypt.file"))
                {
                    fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
                }
                //saving the key and IV to files to be used later
                string x = textBox2.Text + "\\key.txt";
                File.WriteAllBytes(x, aesalg.Key);

                string y = textBox2.Text + "\\IV.txt";
                File.WriteAllBytes(y, aesalg.IV);
            }
            else if (echoiceBox.SelectedItem.ToString() == "RSA")
            {
                // Encrypt file
                encryptedbyte = tempByte.RSAEncryption(file, RSA.ExportParameters(false), false);
                //txtencrypt.Text = ByteConverter.GetString(encryptedtext);
                using (Stream fileS = File.OpenWrite(textBox2.Text + "\\encrypt.file"))
                {
                    fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
                }
            }
            else
            {
                MessageBox.Show("Please choose an encryption method.");
            }

        }
        

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Decryption tempByte = new Decryption();
            
           
            if (dchoiceBox.SelectedItem.ToString() == "AES")
            {
                //calls the decryption function and then writes the contents to a file to verify decryption was successful
                byte[] outputbyte = tempByte.DecryptFileFromBytes_Aes(file, key, IV);
                using (Stream fileS = File.OpenWrite(textBox4.Text + "\\decrypted.file"))
                {
                    fileS.Write(outputbyte, 0, outputbyte.Length);
                }
            }
            else if (dchoiceBox.SelectedItem.ToString() == "RSA")
            {
                byte[] decryptedbyte = tempByte.RSADecryption(encryptedbyte, RSA.ExportParameters(true), false);
                //txtdecrypt.Text = ByteConverter.GetString(decryptedbyte);
                using (Stream fileS = File.OpenWrite(textBox4.Text + "\\decrypted.txt"))
                {
                    fileS.Write(decryptedbyte, 0, decryptedbyte.Length);
                }

            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            senderino.Connect(textBox8.Text, file);
        }


        private void receiveBtn_Click(object sender, EventArgs e)
        {
            reciever.Receive(textBox9.Text, textBox7.Text + "\\decrypt.file");
        }



                //Browser Stuff (Save Location..., Browse...)

        //Encrypt
        public void FileSelectBtnEncrypt_Click(object sender, EventArgs e)
        {
            fileSelect(this.textBox1, this.openFileDialog1);
        }
        private void SaveLocEncrypt_Click(object sender, EventArgs e)
        {
            ChooseFolder(textBox2);
        }

        //Decrypt
        private void FileSelectBtnDecrypt_Click(object sender, EventArgs e)
        {
            fileSelect(this.textBox3, this.openFileDialog1);
        }

        private void SaveLocDecrypt_Click(object sender, EventArgs e)
        {
            ChooseFolder(textBox4);
        }

        //Send
        private void FileSelectBtnSend_Click(object sender, EventArgs e)
        {
            fileSelect(this.textBox5, this.openFileDialog1);
        }


        //Receive
        private void FileSelectBtnReceive_Click(object sender, EventArgs e)
        {
            fileSelect(this.textBox6, this.openFileDialog1);
        }
        private void SaveLocReceive_Click(object sender, EventArgs e)
        {
            ChooseFolder(textBox7);
        }


        //Other Stuff
        private void EncryptionSystemForm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e) {

           keySelect(this.textBox10, this.openFileDialog1);

        }
        private void IVBtn_Click(object sender, EventArgs e)
        {

            IVSelect(this.textBox11, this.openFileDialog1);

        }


        //Functions

        private void fileSelect(TextBox textbox, OpenFileDialog dialog)
        {
            //this just summons the file explorer with settings and then handles the filename and path
            var pathWithEnv = @"%USERPROFILE%\Documents";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            dialog.InitialDirectory = filePath;
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            path = dialog.FileName;
            if (path.Length>0)
            {

                file = File.ReadAllBytes(path);

                string Filename = dialog.SafeFileName;
                textbox.Text = Filename;
            }
            else {
                return;
            }
        }
        private void keySelect(TextBox textbox, OpenFileDialog dialog)
        {
            //this just summons the file explorer with settings and then handles the filename and path
            var pathWithEnv = @"%USERPROFILE%\Documents";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            dialog.InitialDirectory = filePath;
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            string keypath = dialog.FileName;
            if (keypath.Length > 0)
            {

                key = File.ReadAllBytes(keypath);
                string Filename = dialog.SafeFileName;
                textbox.Text = Filename;
            }
            else
            {
                return;
            }
        }
        private void IVSelect(TextBox textbox, OpenFileDialog dialog)
        {
            //this just summons the file explorer with settings and then handles the filename and path
            var pathWithEnv = @"%USERPROFILE%\Documents";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            dialog.InitialDirectory = filePath;
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            string IVpath = dialog.FileName;
            if (IVpath.Length > 0)
            {

                IV = File.ReadAllBytes(IVpath);
                string Filename = dialog.SafeFileName;
                textbox.Text = Filename;
            }
            else
            {
                return;
            }
        }

        //Folder selection https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=net-5.0
        public void ChooseFolder(TextBox textbox)           
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}