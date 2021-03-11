
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
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(123, 206);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(109, 47);
            this.encryptBtn.TabIndex = 4;
            this.encryptBtn.Text = "Encrypt File";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(903, 504);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(86, 23);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt File";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(384, 428);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(221, 73);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit Application";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(770, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Will be used later deleting is not worth it";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(384, 206);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(125, 47);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "Send File";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Location = new System.Drawing.Point(636, 206);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(110, 46);
            this.receiveBtn.TabIndex = 10;
            this.receiveBtn.Text = "Receive File";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // EncryptionSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1001, 574);
            this.ControlBox = false;
            this.Controls.Add(this.receiveBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Name = "EncryptionSystemForm";
            this.Text = "Encryption System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button receiveBtn;
    }
}

