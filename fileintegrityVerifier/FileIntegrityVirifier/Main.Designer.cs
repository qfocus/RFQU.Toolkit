namespace HashIntegrityVirifier
{
    partial class FileIntegrityVerifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileIntegrityVerifier));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileMd5 = new System.Windows.Forms.TextBox();
            this.txtFileSha1 = new System.Windows.Forms.TextBox();
            this.pbMd5 = new System.Windows.Forms.PictureBox();
            this.pbSha1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSha1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(232, 170);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 21);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(105, 18);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(53, 12);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "filePath";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "MD5 Value : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sha1Value :";
            // 
            // txtMd5
            // 
            this.txtMd5.Location = new System.Drawing.Point(120, 48);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.Size = new System.Drawing.Size(279, 21);
            this.txtMd5.TabIndex = 3;
            // 
            // txtSha1
            // 
            this.txtSha1.Location = new System.Drawing.Point(120, 107);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.Size = new System.Drawing.Size(279, 21);
            this.txtSha1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "FilePath :";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(321, 170);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 21);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "Verify";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "FileMD5Value :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "FileSha1Value:";
            // 
            // txtFileMd5
            // 
            this.txtFileMd5.Location = new System.Drawing.Point(120, 76);
            this.txtFileMd5.Name = "txtFileMd5";
            this.txtFileMd5.ReadOnly = true;
            this.txtFileMd5.Size = new System.Drawing.Size(279, 21);
            this.txtFileMd5.TabIndex = 3;
            // 
            // txtFileSha1
            // 
            this.txtFileSha1.Location = new System.Drawing.Point(120, 137);
            this.txtFileSha1.Name = "txtFileSha1";
            this.txtFileSha1.ReadOnly = true;
            this.txtFileSha1.Size = new System.Drawing.Size(279, 21);
            this.txtFileSha1.TabIndex = 3;
            // 
            // pbMd5
            // 
            this.pbMd5.Image = global::HashIntegrityVirifier.Properties.Resources.right;
            this.pbMd5.Location = new System.Drawing.Point(405, 76);
            this.pbMd5.Name = "pbMd5";
            this.pbMd5.Size = new System.Drawing.Size(43, 15);
            this.pbMd5.TabIndex = 6;
            this.pbMd5.TabStop = false;
            // 
            // pbSha1
            // 
            this.pbSha1.Location = new System.Drawing.Point(404, 137);
            this.pbSha1.Name = "pbSha1";
            this.pbSha1.Size = new System.Drawing.Size(43, 15);
            this.pbSha1.TabIndex = 6;
            this.pbSha1.TabStop = false;
            // 
            // FileIntegrityVerifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 198);
            this.Controls.Add(this.pbSha1);
            this.Controls.Add(this.pbMd5);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.txtFileSha1);
            this.Controls.Add(this.txtFileMd5);
            this.Controls.Add(this.txtMd5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileIntegrityVerifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileIntegrityVerifier";
            this.Load += new System.EventHandler(this.HashIntegrityVerifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSha1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileMd5;
        private System.Windows.Forms.TextBox txtFileSha1;
        private System.Windows.Forms.PictureBox pbMd5;
        private System.Windows.Forms.PictureBox pbSha1;
    }
}

