
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
            this.decryptBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SaveLocDecrypt = new System.Windows.Forms.Button();
            this.FileSelectBtnDecrypt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SaveLocReceive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FileSelectBtnReceive = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileSelectBtnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.FileSelectBtnEncrypt = new System.Windows.Forms.Button();
            this.SaveLocEncrypt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(357, 211);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(111, 47);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(388, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(98, 46);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit Application";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.SaveLocDecrypt);
            this.panel1.Controls.Add(this.FileSelectBtnDecrypt);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.decryptBtn);
            this.panel1.Location = new System.Drawing.Point(503, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 275);
            this.panel1.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 23);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 23);
            this.textBox3.TabIndex = 16;
            // 
            // SaveLocDecrypt
            // 
            this.SaveLocDecrypt.Location = new System.Drawing.Point(327, 133);
            this.SaveLocDecrypt.Name = "SaveLocDecrypt";
            this.SaveLocDecrypt.Size = new System.Drawing.Size(127, 30);
            this.SaveLocDecrypt.TabIndex = 15;
            this.SaveLocDecrypt.Text = "Save Location...";
            this.SaveLocDecrypt.UseVisualStyleBackColor = true;
            this.SaveLocDecrypt.Click += new System.EventHandler(this.SaveLocDecrypt_Click);
            // 
            // FileSelectBtnDecrypt
            // 
            this.FileSelectBtnDecrypt.Location = new System.Drawing.Point(327, 77);
            this.FileSelectBtnDecrypt.Name = "FileSelectBtnDecrypt";
            this.FileSelectBtnDecrypt.Size = new System.Drawing.Size(127, 30);
            this.FileSelectBtnDecrypt.TabIndex = 13;
            this.FileSelectBtnDecrypt.Text = "Browse...";
            this.FileSelectBtnDecrypt.UseVisualStyleBackColor = true;
            this.FileSelectBtnDecrypt.Click += new System.EventHandler(this.FileSelectBtnDecrypt_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.receiveBtn);
            this.panel3.Controls.Add(this.SaveLocReceive);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.FileSelectBtnReceive);
            this.panel3.Location = new System.Drawing.Point(503, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 269);
            this.panel3.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(183, 224);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 23);
            this.textBox9.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 146);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(300, 23);
            this.textBox7.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(300, 23);
            this.textBox6.TabIndex = 19;
            // 
            // SaveLocReceive
            // 
            this.SaveLocReceive.Location = new System.Drawing.Point(327, 141);
            this.SaveLocReceive.Name = "SaveLocReceive";
            this.SaveLocReceive.Size = new System.Drawing.Size(127, 30);
            this.SaveLocReceive.TabIndex = 14;
            this.SaveLocReceive.Text = "Save Location...";
            this.SaveLocReceive.UseVisualStyleBackColor = true;
            this.SaveLocReceive.Click += new System.EventHandler(this.SaveLocReceive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Local IP";
            // 
            // FileSelectBtnReceive
            // 
            this.FileSelectBtnReceive.Location = new System.Drawing.Point(327, 82);
            this.FileSelectBtnReceive.Name = "FileSelectBtnReceive";
            this.FileSelectBtnReceive.Size = new System.Drawing.Size(127, 30);
            this.FileSelectBtnReceive.TabIndex = 15;
            this.FileSelectBtnReceive.Text = "Browse...";
            this.FileSelectBtnReceive.UseVisualStyleBackColor = true;
            this.FileSelectBtnReceive.Click += new System.EventHandler(this.FileSelectBtnReceive_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.FileSelectBtnSend);
            this.panel4.Controls.Add(this.sendBtn);
            this.panel4.Location = new System.Drawing.Point(12, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 269);
            this.panel4.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(181, 224);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(170, 23);
            this.textBox8.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 23);
            this.textBox5.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Receiver\'s IP";
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
            // openFileDialog1
            // 

            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(357, 211);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(109, 47);
            this.encryptBtn.TabIndex = 4;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // FileSelectBtnEncrypt
            // 
            this.FileSelectBtnEncrypt.Location = new System.Drawing.Point(327, 77);
            this.FileSelectBtnEncrypt.Name = "FileSelectBtnEncrypt";
            this.FileSelectBtnEncrypt.Size = new System.Drawing.Size(127, 30);
            this.FileSelectBtnEncrypt.TabIndex = 12;
            this.FileSelectBtnEncrypt.Text = "Browse...";
            this.FileSelectBtnEncrypt.UseVisualStyleBackColor = true;
            this.FileSelectBtnEncrypt.Click += new System.EventHandler(this.FileSelectBtnEncrypt_Click);
            // 
            // SaveLocEncrypt
            // 
            this.SaveLocEncrypt.Location = new System.Drawing.Point(327, 132);
            this.SaveLocEncrypt.Name = "SaveLocEncrypt";
            this.SaveLocEncrypt.Size = new System.Drawing.Size(127, 30);
            this.SaveLocEncrypt.TabIndex = 13;
            this.SaveLocEncrypt.Text = "Save Location...";
            this.SaveLocEncrypt.UseVisualStyleBackColor = true;
            this.SaveLocEncrypt.Click += new System.EventHandler(this.SaveLocEncrypt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.SaveLocEncrypt);
            this.panel2.Controls.Add(this.FileSelectBtnEncrypt);
            this.panel2.Controls.Add(this.encryptBtn);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 275);
            this.panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 23);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 23);
            this.textBox1.TabIndex = 14;
            // 
            // EncryptionSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1001, 574);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EncryptionSystemForm";
            this.Text = "Encryption System";
            this.Load += new System.EventHandler(this.EncryptionSystemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button FileSelectBtnReceive;
        private System.Windows.Forms.Button FileSelectBtnSend;
        private System.Windows.Forms.Button FileSelectBtnDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveLocDecrypt;
        private System.Windows.Forms.Button SaveLocReceive;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button FileSelectBtnEncrypt;
        private System.Windows.Forms.Button SaveLocEncrypt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
    }
}

