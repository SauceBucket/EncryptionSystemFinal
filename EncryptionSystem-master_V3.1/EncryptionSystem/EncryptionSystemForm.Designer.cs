
using System.Windows.Forms;

namespace EncryptionSystem
{
    partial class EncryptionSystemForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionSystemForm));
            this.decryptBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.panelDecrypt = new System.Windows.Forms.Panel();
            this.DecryptTbox3 = new System.Windows.Forms.TextBox();
            this.DecryptZipBtn = new System.Windows.Forms.Button();
            this.DecryptZipSelectBtn = new System.Windows.Forms.Button();
            this.DecryptTbox2 = new System.Windows.Forms.TextBox();
            this.DecryptTbox1 = new System.Windows.Forms.TextBox();
            this.SaveLocDecryptBtn = new System.Windows.Forms.Button();
            this.FileSelectBtnDecrypt = new System.Windows.Forms.Button();
            this.DCryptselect = new System.Windows.Forms.ListBox();
            this.panelRecieve = new System.Windows.Forms.Panel();
            this.RecieveTbox3 = new System.Windows.Forms.TextBox();
            this.RecieveTbox2 = new System.Windows.Forms.TextBox();
            this.SaveLocRecieveBtn = new System.Windows.Forms.Button();
            this.LocalIP_lable = new System.Windows.Forms.Label();
            this.panelSend = new System.Windows.Forms.Panel();
            this.SendTbox2 = new System.Windows.Forms.TextBox();
            this.SendTbox1 = new System.Windows.Forms.TextBox();
            this.RecieverIP_label = new System.Windows.Forms.Label();
            this.FileSelectBtnSend = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEncrypt = new System.Windows.Forms.TabPage();
            this.panelEncrypt = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptFolderBrowseBtn = new System.Windows.Forms.Button();
            this.EncryptTbox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileSelectBtnEncrypt = new System.Windows.Forms.Button();
            this.EncryptTbox2 = new System.Windows.Forms.TextBox();
            this.EncryptTbox1 = new System.Windows.Forms.TextBox();
            this.SaveLocEncryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.ECryptselect = new System.Windows.Forms.ListBox();
            this.tabPageDecrypt = new System.Windows.Forms.TabPage();
            this.tabPageSend = new System.Windows.Forms.TabPage();
            this.tabPageRecieve = new System.Windows.Forms.TabPage();
            this.EncryptionGUI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HelpBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panelDecrypt.SuspendLayout();
            this.panelRecieve.SuspendLayout();
            this.panelSend.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageEncrypt.SuspendLayout();
            this.panelEncrypt.SuspendLayout();
            this.tabPageDecrypt.SuspendLayout();
            this.tabPageSend.SuspendLayout();
            this.tabPageRecieve.SuspendLayout();
            this.SuspendLayout();
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(343, 177);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(111, 47);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(357, 211);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(109, 47);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(357, 211);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(111, 47);
            this.receiveBtn.TabIndex = 10;
            this.receiveBtn.Text = "Receive";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // panelDecrypt
            // 
            this.panelDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDecrypt.Controls.Add(this.DecryptTbox3);
            this.panelDecrypt.Controls.Add(this.DecryptZipBtn);
            this.panelDecrypt.Controls.Add(this.DecryptZipSelectBtn);
            this.panelDecrypt.Controls.Add(this.DecryptTbox2);
            this.panelDecrypt.Controls.Add(this.DecryptTbox1);
            this.panelDecrypt.Controls.Add(this.SaveLocDecryptBtn);
            this.panelDecrypt.Controls.Add(this.FileSelectBtnDecrypt);
            this.panelDecrypt.Controls.Add(this.decryptBtn);
            this.panelDecrypt.Controls.Add(this.DCryptselect);
            this.panelDecrypt.Location = new System.Drawing.Point(0, 3);
            this.panelDecrypt.Name = "panelDecrypt";
            this.panelDecrypt.Size = new System.Drawing.Size(882, 501);
            this.panelDecrypt.TabIndex = 13;
            // 
            // DecryptTbox3
            // 
            this.DecryptTbox3.Location = new System.Drawing.Point(10, 247);
            this.DecryptTbox3.Name = "DecryptTbox3";
            this.DecryptTbox3.Size = new System.Drawing.Size(300, 23);
            this.DecryptTbox3.TabIndex = 21;
            this.DecryptTbox3.Text = "Zipped Folder";
            // 
            // DecryptZipBtn
            // 
            this.DecryptZipBtn.Location = new System.Drawing.Point(343, 307);
            this.DecryptZipBtn.Name = "DecryptZipBtn";
            this.DecryptZipBtn.Size = new System.Drawing.Size(110, 49);
            this.DecryptZipBtn.TabIndex = 20;
            this.DecryptZipBtn.Text = "Decrypt Zip";
            this.DecryptZipBtn.UseVisualStyleBackColor = true;
            this.DecryptZipBtn.Click += new System.EventHandler(this.DecryptZipBtn_Click);
            // 
            // DecryptZipSelectBtn
            // 
            this.DecryptZipSelectBtn.Location = new System.Drawing.Point(327, 247);
            this.DecryptZipSelectBtn.Name = "DecryptZipSelectBtn";
            this.DecryptZipSelectBtn.Size = new System.Drawing.Size(127, 24);
            this.DecryptZipSelectBtn.TabIndex = 19;
            this.DecryptZipSelectBtn.Text = "Browse...";
            this.DecryptZipSelectBtn.UseVisualStyleBackColor = true;
            this.DecryptZipSelectBtn.Click += new System.EventHandler(this.DecryptZipSelectBtn_Click);
            // 
            // DecryptTbox2
            // 
            this.DecryptTbox2.Location = new System.Drawing.Point(10, 130);
            this.DecryptTbox2.Name = "DecryptTbox2";
            this.DecryptTbox2.Size = new System.Drawing.Size(300, 23);
            this.DecryptTbox2.TabIndex = 17;
            this.DecryptTbox2.TextChanged += new System.EventHandler(this.DecryptTbox2_TextChanged);
            // 
            // DecryptTbox1
            // 
            this.DecryptTbox1.Location = new System.Drawing.Point(10, 82);
            this.DecryptTbox1.Name = "DecryptTbox1";
            this.DecryptTbox1.Size = new System.Drawing.Size(300, 23);
            this.DecryptTbox1.TabIndex = 16;
            this.DecryptTbox1.Text = "Folder (AES)";
            // 
            // SaveLocDecryptBtn
            // 
            this.SaveLocDecryptBtn.Location = new System.Drawing.Point(327, 125);
            this.SaveLocDecryptBtn.Name = "SaveLocDecryptBtn";
            this.SaveLocDecryptBtn.Size = new System.Drawing.Size(127, 30);
            this.SaveLocDecryptBtn.TabIndex = 15;
            this.SaveLocDecryptBtn.Text = "Save Location...";
            this.SaveLocDecryptBtn.UseVisualStyleBackColor = true;
            this.SaveLocDecryptBtn.Click += new System.EventHandler(this.SaveLocDecrypt_Click);
            // 
            // FileSelectBtnDecrypt
            // 
            this.FileSelectBtnDecrypt.Location = new System.Drawing.Point(327, 77);
            this.FileSelectBtnDecrypt.Name = "FileSelectBtnDecrypt";
            this.FileSelectBtnDecrypt.Size = new System.Drawing.Size(127, 30);
            this.FileSelectBtnDecrypt.TabIndex = 13;
            this.FileSelectBtnDecrypt.Text = "Browse...";
            this.FileSelectBtnDecrypt.UseVisualStyleBackColor = true;
            this.FileSelectBtnDecrypt.Click += new System.EventHandler(this.FolderSelectBtn_Click);
            // 
            // DCryptselect
            // 
            this.DCryptselect.FormattingEnabled = true;
            this.DCryptselect.ItemHeight = 15;
            this.DCryptselect.Items.AddRange(new object[] {
            "RSA",
            "AES"});
            this.DCryptselect.Location = new System.Drawing.Point(10, 307);
            this.DCryptselect.Name = "DCryptselect";
            this.DCryptselect.Size = new System.Drawing.Size(123, 49);
            this.DCryptselect.TabIndex = 0;
            // 
            // panelRecieve
            // 
            this.panelRecieve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecieve.Controls.Add(this.RecieveTbox3);
            this.panelRecieve.Controls.Add(this.RecieveTbox2);
            this.panelRecieve.Controls.Add(this.receiveBtn);
            this.panelRecieve.Controls.Add(this.SaveLocRecieveBtn);
            this.panelRecieve.Controls.Add(this.LocalIP_lable);
            this.panelRecieve.Location = new System.Drawing.Point(3, 3);
            this.panelRecieve.Name = "panelRecieve";
            this.panelRecieve.Size = new System.Drawing.Size(879, 501);
            this.panelRecieve.TabIndex = 14;
            // 
            // RecieveTbox3
            // 
            this.RecieveTbox3.Location = new System.Drawing.Point(183, 224);
            this.RecieveTbox3.Name = "RecieveTbox3";
            this.RecieveTbox3.Size = new System.Drawing.Size(168, 23);
            this.RecieveTbox3.TabIndex = 21;
            // 
            // RecieveTbox2
            // 
            this.RecieveTbox2.Location = new System.Drawing.Point(10, 146);
            this.RecieveTbox2.Name = "RecieveTbox2";
            this.RecieveTbox2.Size = new System.Drawing.Size(300, 23);
            this.RecieveTbox2.TabIndex = 20;
            // 
            // SaveLocRecieveBtn
            // 
            this.SaveLocRecieveBtn.Location = new System.Drawing.Point(327, 141);
            this.SaveLocRecieveBtn.Name = "SaveLocRecieveBtn";
            this.SaveLocRecieveBtn.Size = new System.Drawing.Size(127, 30);
            this.SaveLocRecieveBtn.TabIndex = 14;
            this.SaveLocRecieveBtn.Text = "Save Location...";
            this.SaveLocRecieveBtn.UseVisualStyleBackColor = true;
            this.SaveLocRecieveBtn.Click += new System.EventHandler(this.SaveLocReceive_Click);
            // 
            // LocalIP_lable
            // 
            this.LocalIP_lable.AutoSize = true;
            this.LocalIP_lable.Location = new System.Drawing.Point(183, 202);
            this.LocalIP_lable.Name = "LocalIP_lable";
            this.LocalIP_lable.Size = new System.Drawing.Size(48, 15);
            this.LocalIP_lable.TabIndex = 18;
            this.LocalIP_lable.Text = "Local IP";
            // 
            // panelSend
            // 
            this.panelSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSend.Controls.Add(this.SendTbox2);
            this.panelSend.Controls.Add(this.SendTbox1);
            this.panelSend.Controls.Add(this.RecieverIP_label);
            this.panelSend.Controls.Add(this.FileSelectBtnSend);
            this.panelSend.Controls.Add(this.sendBtn);
            this.panelSend.Location = new System.Drawing.Point(0, 0);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(882, 504);
            this.panelSend.TabIndex = 14;
            // 
            // SendTbox2
            // 
            this.SendTbox2.Location = new System.Drawing.Point(181, 224);
            this.SendTbox2.Name = "SendTbox2";
            this.SendTbox2.Size = new System.Drawing.Size(170, 23);
            this.SendTbox2.TabIndex = 21;
            // 
            // SendTbox1
            // 
            this.SendTbox1.Location = new System.Drawing.Point(9, 113);
            this.SendTbox1.Name = "SendTbox1";
            this.SendTbox1.Size = new System.Drawing.Size(300, 23);
            this.SendTbox1.TabIndex = 18;
            this.SendTbox1.Text = "Zipped File / Folder";
            // 
            // RecieverIP_label
            // 
            this.RecieverIP_label.AutoSize = true;
            this.RecieverIP_label.Location = new System.Drawing.Point(181, 202);
            this.RecieverIP_label.Name = "RecieverIP_label";
            this.RecieverIP_label.Size = new System.Drawing.Size(72, 15);
            this.RecieverIP_label.TabIndex = 17;
            this.RecieverIP_label.Text = "Receiver\'s IP";
            // 
            // FileSelectBtnSend
            // 
            this.FileSelectBtnSend.Location = new System.Drawing.Point(327, 108);
            this.FileSelectBtnSend.Name = "FileSelectBtnSend";
            this.FileSelectBtnSend.Size = new System.Drawing.Size(127, 30);
            this.FileSelectBtnSend.TabIndex = 14;
            this.FileSelectBtnSend.Text = "Browse...";
            this.FileSelectBtnSend.UseVisualStyleBackColor = true;
            this.FileSelectBtnSend.Click += new System.EventHandler(this.FileSelectBtnSend_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEncrypt);
            this.tabControl.Controls.Add(this.tabPageDecrypt);
            this.tabControl.Controls.Add(this.tabPageSend);
            this.tabControl.Controls.Add(this.tabPageRecieve);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(893, 535);
            this.tabControl.TabIndex = 1000;
            // 
            // tabPageEncrypt
            // 
            this.tabPageEncrypt.Controls.Add(this.panelEncrypt);
            this.tabPageEncrypt.Location = new System.Drawing.Point(4, 24);
            this.tabPageEncrypt.Name = "tabPageEncrypt";
            this.tabPageEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncrypt.Size = new System.Drawing.Size(885, 507);
            this.tabPageEncrypt.TabIndex = 4;
            this.tabPageEncrypt.Text = "Encrypt";
            this.tabPageEncrypt.UseVisualStyleBackColor = true;
            // 
            // panelEncrypt
            // 
            this.panelEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEncrypt.Controls.Add(this.label3);
            this.panelEncrypt.Controls.Add(this.label2);
            this.panelEncrypt.Controls.Add(this.EncryptFolderBrowseBtn);
            this.panelEncrypt.Controls.Add(this.EncryptTbox4);
            this.panelEncrypt.Controls.Add(this.label1);
            this.panelEncrypt.Controls.Add(this.FileSelectBtnEncrypt);
            this.panelEncrypt.Controls.Add(this.EncryptTbox2);
            this.panelEncrypt.Controls.Add(this.EncryptTbox1);
            this.panelEncrypt.Controls.Add(this.SaveLocEncryptBtn);
            this.panelEncrypt.Controls.Add(this.encryptBtn);
            this.panelEncrypt.Controls.Add(this.ECryptselect);
            this.panelEncrypt.Location = new System.Drawing.Point(3, 3);
            this.panelEncrypt.Name = "panelEncrypt";
            this.panelEncrypt.Size = new System.Drawing.Size(879, 501);
            this.panelEncrypt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Select Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // EncryptFolderBrowseBtn
            // 
            this.EncryptFolderBrowseBtn.Location = new System.Drawing.Point(327, 126);
            this.EncryptFolderBrowseBtn.Name = "EncryptFolderBrowseBtn";
            this.EncryptFolderBrowseBtn.Size = new System.Drawing.Size(127, 24);
            this.EncryptFolderBrowseBtn.TabIndex = 19;
            this.EncryptFolderBrowseBtn.Text = "Browse...";
            this.EncryptFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.EncryptFolderBrowseBtn.Click += new System.EventHandler(this.EncryptFolderBrowseBtn_Click);
            // 
            // EncryptTbox4
            // 
            this.EncryptTbox4.Location = new System.Drawing.Point(9, 126);
            this.EncryptTbox4.Name = "EncryptTbox4";
            this.EncryptTbox4.Size = new System.Drawing.Size(300, 23);
            this.EncryptTbox4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Single File";
            // 
            // FileSelectBtnEncrypt
            // 
            this.FileSelectBtnEncrypt.Location = new System.Drawing.Point(327, 77);
            this.FileSelectBtnEncrypt.Name = "FileSelectBtnEncrypt";
            this.FileSelectBtnEncrypt.Size = new System.Drawing.Size(127, 28);
            this.FileSelectBtnEncrypt.TabIndex = 12;
            this.FileSelectBtnEncrypt.Text = "Browse...";
            this.FileSelectBtnEncrypt.UseVisualStyleBackColor = true;
            this.FileSelectBtnEncrypt.Click += new System.EventHandler(this.FileSelectBtnEncrypt_Click);
            // 
            // EncryptTbox2
            // 
            this.EncryptTbox2.Location = new System.Drawing.Point(9, 167);
            this.EncryptTbox2.Name = "EncryptTbox2";
            this.EncryptTbox2.Size = new System.Drawing.Size(300, 23);
            this.EncryptTbox2.TabIndex = 13;
            // 
            // EncryptTbox1
            // 
            this.EncryptTbox1.Location = new System.Drawing.Point(9, 82);
            this.EncryptTbox1.Name = "EncryptTbox1";
            this.EncryptTbox1.Size = new System.Drawing.Size(300, 23);
            this.EncryptTbox1.TabIndex = 14;
            // 
            // SaveLocEncryptBtn
            // 
            this.SaveLocEncryptBtn.Location = new System.Drawing.Point(327, 166);
            this.SaveLocEncryptBtn.Name = "SaveLocEncryptBtn";
            this.SaveLocEncryptBtn.Size = new System.Drawing.Size(127, 23);
            this.SaveLocEncryptBtn.TabIndex = 13;
            this.SaveLocEncryptBtn.Text = "Save Location...";
            this.SaveLocEncryptBtn.UseVisualStyleBackColor = true;
            this.SaveLocEncryptBtn.Click += new System.EventHandler(this.SaveLocEncrypt_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(327, 211);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(109, 47);
            this.encryptBtn.TabIndex = 4;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // ECryptselect
            // 
            this.ECryptselect.FormattingEnabled = true;
            this.ECryptselect.ItemHeight = 15;
            this.ECryptselect.Items.AddRange(new object[] {
            "RSA",
            "AES"});
            this.ECryptselect.Location = new System.Drawing.Point(9, 211);
            this.ECryptselect.Name = "ECryptselect";
            this.ECryptselect.Size = new System.Drawing.Size(127, 49);
            this.ECryptselect.TabIndex = 0;
            // 
            // tabPageDecrypt
            // 
            this.tabPageDecrypt.Controls.Add(this.panelDecrypt);
            this.tabPageDecrypt.Location = new System.Drawing.Point(4, 24);
            this.tabPageDecrypt.Name = "tabPageDecrypt";
            this.tabPageDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecrypt.Size = new System.Drawing.Size(885, 507);
            this.tabPageDecrypt.TabIndex = 1;
            this.tabPageDecrypt.Text = "Decrypt";
            this.tabPageDecrypt.UseVisualStyleBackColor = true;
            // 
            // tabPageSend
            // 
            this.tabPageSend.Controls.Add(this.panelSend);
            this.tabPageSend.Location = new System.Drawing.Point(4, 24);
            this.tabPageSend.Name = "tabPageSend";
            this.tabPageSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSend.Size = new System.Drawing.Size(885, 507);
            this.tabPageSend.TabIndex = 2;
            this.tabPageSend.Text = "Send";
            this.tabPageSend.UseVisualStyleBackColor = true;
            // 
            // tabPageRecieve
            // 
            this.tabPageRecieve.Controls.Add(this.panelRecieve);
            this.tabPageRecieve.Location = new System.Drawing.Point(4, 24);
            this.tabPageRecieve.Name = "tabPageRecieve";
            this.tabPageRecieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecieve.Size = new System.Drawing.Size(885, 507);
            this.tabPageRecieve.TabIndex = 3;
            this.tabPageRecieve.Text = "Receive";
            this.tabPageRecieve.UseVisualStyleBackColor = true;
            // 
            // EncryptionGUI
            // 
            this.EncryptionGUI.Name = "contextMenuStrip1";
            this.EncryptionGUI.Size = new System.Drawing.Size(61, 4);
            // 
            // HelpBtn
            // 
            this.HelpBtn.AutoSize = true;
            this.HelpBtn.Location = new System.Drawing.Point(931, 36);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(62, 38);
            this.HelpBtn.TabIndex = 1001;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 501);
            this.panel2.TabIndex = 20;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(351, 185);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // EncryptionSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1005, 558);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.tabControl);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptionSystemForm";
            this.Text = "Encryption System";
            this.Load += new System.EventHandler(this.EncryptionSystemForm_Load);
            this.panelDecrypt.ResumeLayout(false);
            this.panelDecrypt.PerformLayout();
            this.panelRecieve.ResumeLayout(false);
            this.panelRecieve.PerformLayout();
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageEncrypt.ResumeLayout(false);
            this.panelEncrypt.ResumeLayout(false);
            this.panelEncrypt.PerformLayout();
            this.tabPageDecrypt.ResumeLayout(false);
            this.tabPageSend.ResumeLayout(false);
            this.tabPageRecieve.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Panel panelDecrypt;
        private System.Windows.Forms.Panel panelRecieve;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Button FileSelectBtnSend;
        private System.Windows.Forms.Button FileSelectBtnDecrypt;
        private System.Windows.Forms.Label LocalIP_lable;
        private System.Windows.Forms.Label RecieverIP_label;
        private System.Windows.Forms.Button SaveLocDecryptBtn;
        private System.Windows.Forms.Button SaveLocRecieveBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox DecryptTbox2;
        private System.Windows.Forms.TextBox DecryptTbox1;
        private System.Windows.Forms.TextBox RecieveTbox3;
        private System.Windows.Forms.TextBox RecieveTbox2;
        private System.Windows.Forms.TextBox SendTbox2;
        private System.Windows.Forms.TextBox SendTbox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDecrypt;
        private System.Windows.Forms.TabPage tabPageSend;
        private System.Windows.Forms.TabPage tabPageRecieve;
        private System.Windows.Forms.TabPage tabPageEncrypt;
        private System.Windows.Forms.ContextMenuStrip EncryptionGUI;
        private System.Windows.Forms.ListBox DCryptselect;
        private System.Windows.Forms.Button HelpBtn;
        private Panel panelEncrypt;
        private Label label3;
        private Label label2;
        private Button EncryptFolderBrowseBtn;
        private TextBox EncryptTbox4;
        private Label label1;
        private Button FileSelectBtnEncrypt;
        private TextBox EncryptTbox2;
        private TextBox EncryptTbox1;
        private Button SaveLocEncryptBtn;
        private Button encryptBtn;
        private ListBox ECryptselect;
        private Button DecryptZipSelectBtn;
        private Button DecryptZipBtn;
        private Panel panel2;
        private Button button9;
        private TextBox DecryptTbox3;
    }
}

