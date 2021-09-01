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
using System.IO.Compression;
using System.Security.AccessControl;

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
        byte[] file=null;
        string filepath;
        string folderpathSavLoc;
        string folderpath;
        string filenameG;
        string[] filepaths=null;
        byte[] key;
        byte[] IV;
        byte[] pkByte;
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
            if (file != null) //check to see if single file
            {
                if (ECryptselect.SelectedItem.ToString() == "AES")
                {
                    //calls the encryption function and then writes the contents to a file to verify encryption was successful
                    encryptedbyte = tempByte.EncryptFileToBytes_Aes(file, aesalg.Key, aesalg.IV);
                    tempByte.EncryptAESfile(filenameG, EncryptTbox2.Text, encryptedbyte, aesalg);
                    

                }
                else if (ECryptselect.SelectedItem.ToString() == "RSA")
                {
                    var privKey = RSA.ExportParameters(true);
                    string privateKey;
                    string[] temp;
                    string trimmedpath = EncryptTbox2.Text + '\\' + filenameG;
                    temp = trimmedpath.Split('.', 2);
                    trimmedpath = temp[0];
                    Directory.CreateDirectory(trimmedpath);


                    //we need some buffer
                    var sw = new StringWriter();
                    //we need a serializer
                    var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                    //serialize the key into the stream
                    xs.Serialize(sw, privKey);
                    //get the string from the stream
                    privateKey = sw.ToString();

                    pkByte = Encoding.ASCII.GetBytes(privateKey);

                    // Encrypt file using RSA
                    encryptedbyte = tempByte.RSAEncryption(file, RSA.ExportParameters(false), false);

                    using (Stream fileS = File.OpenWrite(EncryptTbox2.Text + "\\encrypt.file"))
                    {
                        fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
                    }

                    // Write key to text file
                    string x = EncryptTbox2.Text + "\\key.txt";
                    File.WriteAllBytes(x, pkByte);
                }
                else
                {
                    MessageBox.Show("Please choose an encryption method.");
                }
            }
            else if(filepaths!=null) //check to see if folder
            {
                {
                    if (ECryptselect.SelectedItem.ToString() == "AES") {
                        tempByte.EncryptAESfolder(filepaths, aesalg,folderpathSavLoc);
                    }
                    else if (ECryptselect.SelectedItem.ToString() == "RSA")
                    {
                        byte[] fileit = null;
                        for (int i = 0; i < filepaths.Length; ++i)
                        {
                            string[] temp;
                            string trimmedpath = filepaths[i];
                            temp = trimmedpath.Split('.', 2);
                            trimmedpath = temp[0];
                            Directory.CreateDirectory(trimmedpath);
                            fileit = File.ReadAllBytes(filepaths[i]);
                            // Encrypt file
                            encryptedbyte = tempByte.RSAEncryption(fileit, RSA.ExportParameters(false), false);
                            //txtencrypt.Text = ByteConverter.GetString(encryptedtext);
                            using (Stream fileS = File.OpenWrite(trimmedpath + "\\encrypt.file"))
                            {
                                fileS.Write(encryptedbyte, 0, encryptedbyte.Length);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose an encryption method.");
                    }
                }
            }
            else MessageBox.Show("Please choose an File or Folder to Encrypt");
        }
        

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Decryption tempByte = new Decryption();


            if (DCryptselect.SelectedItem.ToString() == "AES")
            {
                tempByte.DecryptFolderAES(folderpath, folderpathSavLoc);
            }
             else if (DCryptselect.SelectedItem.ToString() == "RSA")
             {
                string privkeyString = Encoding.Default.GetString(key); //get private key as a string
                RSAParameters privKey; //Placeholder for private key

                var sr = new StringReader(privkeyString); // Get stream from string
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters)); //Deserializing 
                privKey = (RSAParameters)xs.Deserialize(sr); // Get object from stream

                RSA.ImportParameters(privKey);

                byte[] decryptedbyte = tempByte.RSADecryption(file, privKey, false);
                //txtdecrypt.Text = ByteConverter.GetString(decryptedbyte);
                using (Stream fileS = File.OpenWrite(DecryptTbox2.Text + "\\decrypted.file"))
                {
                    fileS.Write(decryptedbyte, 0, decryptedbyte.Length);
                }
            }
            else 
            {
                    MessageBox.Show("Please choose an decryption method.");
                
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (SendTbox2.Text.EndsWith("7z") || SendTbox2.Text.EndsWith("zip"))
            {
                
                senderino.Connect(SendTbox2.Text, FileToBytes(SendTbox2.Text));
            }
            else
            {
                senderino.Connect(SendTbox2.Text, file);
            }
        }


        private void receiveBtn_Click(object sender, EventArgs e)
        {
            reciever.Receive(RecieveTbox3.Text, RecieveTbox2.Text + "\\decrypt.file");
        }
        
         

        //Browser Stuff (Save Location..., Browse...)

        //Encrypt
        public void FileSelectBtnEncrypt_Click(object sender, EventArgs e)
        {
            fileSelect(this.EncryptTbox1, this.openFileDialog);
            filepaths = null;
            EncryptTbox4.Text = null;
        }
        private void SaveLocEncrypt_Click(object sender, EventArgs e)
        {
            ChooseFolder(EncryptTbox2);
        }

        //Decrypt
        private void FolderSelectBtn_Click(object sender, EventArgs e)
        {
            if (DCryptselect.SelectedItem == null)
                MessageBox.Show("Please choose an decryption method.");
            else if (DCryptselect.SelectedItem.ToString() == "RSA")
                fileSelect(this.DecryptTbox1, this.openFileDialog);
            else if (DCryptselect.SelectedItem.ToString() == "AES")
                FolderSelect(this.DecryptTbox1, this.folderBrowserDialog);           
        }
        private void DecryptZipSelectBtn_Click(object sender, EventArgs e)
        {
            fileSelectZip(this.DecryptTbox3, this.openFileDialog);
        }
        private void SaveLocDecrypt_Click(object sender, EventArgs e)
        {
            ChooseFolder(DecryptTbox2);
        }
        private void DecryptZipBtn_Click(object sender, EventArgs e)
        {
            
            Decryption tempByte = new Decryption();
            tempByte.DecryptZip(DecryptTbox2.Text,DCryptselect.SelectedItem.ToString(),filepath,RSA);

            

        }
        
        //Send
        private void FileSelectBtnSend_Click(object sender, EventArgs e)
        {
            fileSelect(this.SendTbox1, this.openFileDialog);
        }


        //Receive
        private void SaveLocReceive_Click(object sender, EventArgs e)
        {
            ChooseFolder(RecieveTbox2);
        }


        //Other Stuff
        private void EncryptionSystemForm_Load(object sender, EventArgs e)
        {
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
        }


        //Functions

        private void FolderSelect(TextBox textbox, FolderBrowserDialog dialog)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
               
            //this just summons the file explorer with settings and then handles the filename and path
            
             filepaths = Directory.GetFiles(folderBrowserDialog.SelectedPath);
             folderpath= folderBrowserDialog.SelectedPath;
                textbox.Text = folderBrowserDialog.SelectedPath; 
            }
        }
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
                filenameG = Filename;
            }
            else {
                return;
            }
        }
        private void fileSelectZip(TextBox textbox, OpenFileDialog dialog)
        {
            //this just summons the file explorer with settings and then handles the filename and path
            var pathWithEnv = @"%USERPROFILE%\Documents";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            dialog.InitialDirectory = filePath;
            dialog.RestoreDirectory = true;
            dialog.ShowDialog();
            path = dialog.FileName;
            if (path.Length > 0)
            {

                filepath = path;
                string Filename = dialog.SafeFileName;
                textbox.Text = Filename;
                filenameG = Filename;
            }
            else
            {
                return;
            }
        }

        //Used with zip file to convert to bytes before sending. Stand alone encrypted files are already in the correct format.
        public byte[] FileToBytes(String file)
        {
            return File.ReadAllBytes(file);
        }

        /*                           these are dead functions. Rip!
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
        */
        //Folder selection https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=net-5.0
        public void ChooseFolder(TextBox textbox)           
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textbox.Text = folderBrowserDialog.SelectedPath;
                folderpathSavLoc = folderBrowserDialog.SelectedPath;
            }
        }

        private void EncryptFolderBrowseBtn_Click(object sender, EventArgs e)
        {
             FolderSelect(this.EncryptTbox4, this.folderBrowserDialog);
            file = null;
            EncryptTbox1.Text = null;
            //ChooseFolder(RecieveTbox2);
        }

        private void DecryptTbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}