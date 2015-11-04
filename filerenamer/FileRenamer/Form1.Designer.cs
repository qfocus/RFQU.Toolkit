namespace FileRenamer
{
    partial class Form1
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
            this.fbdChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblFolderLocation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFileNameFormat = new System.Windows.Forms.Label();
            this.txtFileNameFormat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(13, 13);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "选择文件夹";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblFolderLocation
            // 
            this.lblFolderLocation.AutoSize = true;
            this.lblFolderLocation.Location = new System.Drawing.Point(112, 18);
            this.lblFolderLocation.Name = "lblFolderLocation";
            this.lblFolderLocation.Size = new System.Drawing.Size(0, 13);
            this.lblFolderLocation.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFileNameFormat
            // 
            this.lblFileNameFormat.AutoSize = true;
            this.lblFileNameFormat.Location = new System.Drawing.Point(15, 54);
            this.lblFileNameFormat.Name = "lblFileNameFormat";
            this.lblFileNameFormat.Size = new System.Drawing.Size(73, 13);
            this.lblFileNameFormat.TabIndex = 3;
            this.lblFileNameFormat.Text = "文件名格式 :";
            // 
            // txtFileNameFormat
            // 
            this.txtFileNameFormat.Location = new System.Drawing.Point(110, 51);
            this.txtFileNameFormat.Name = "txtFileNameFormat";
            this.txtFileNameFormat.Size = new System.Drawing.Size(253, 20);
            this.txtFileNameFormat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 342);
            this.Controls.Add(this.txtFileNameFormat);
            this.Controls.Add(this.lblFileNameFormat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFolderLocation);
            this.Controls.Add(this.btnChooseFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdChooseFolder;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lblFolderLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFileNameFormat;
        private System.Windows.Forms.TextBox txtFileNameFormat;
    }
}

