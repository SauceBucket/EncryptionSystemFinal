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
      
        //Main Buttons (Encrypt, Decrypt, Send, Receive)

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            Encryption tempByte = new Encryption();

            //calls the encryption function and then writes the contents to a file to verify encryption was successful
            encryptedbyte = tempByte.EncryptFileToBytes_Aes(file, aesalg.Key, aesalg.IV);    
            using (Stream fileS = File.OpenWrite(textBox2.Text + "\\encrypt.file"))
            {
                fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Decryption tempByte = new Decryption();
            //calls the decryption function and then writes the contents to a file to verify decryption was successful
            byte[] outputbyte = tempByte.DecryptFileFromBytes_Aes(encryptedbyte, aesalg.Key, aesalg.IV); 
            using (Stream fileS = File.OpenWrite(textBox4.Text + "\\decrypted.txt"))
            {
                fileS.Write(outputbyte, 0, outputbyte.Length);
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
            file = File.ReadAllBytes(path);

            string Filename = dialog.SafeFileName;
            textbox.Text = Filename;
        }

        //Folder selection https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=net-5.0
        public void ChooseFolder(TextBox textbox)           
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

    }
}