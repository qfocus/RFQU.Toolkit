namespace FileRenamer.UI
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRenameType = new System.Windows.Forms.ComboBox();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOriginName = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(13, 12);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(99, 21);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblFolderLocation
            // 
            this.lblFolderLocation.AutoSize = true;
            this.lblFolderLocation.Location = new System.Drawing.Point(112, 17);
            this.lblFolderLocation.Name = "lblFolderLocation";
            this.lblFolderLocation.Size = new System.Drawing.Size(0, 12);
            this.lblFolderLocation.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(559, 348);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 21);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Value : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "After :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rename Type : ";
            // 
            // cbRenameType
            // 
            this.cbRenameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenameType.FormattingEnabled = true;
            this.cbRenameType.Location = new System.Drawing.Point(115, 48);
            this.cbRenameType.Name = "cbRenameType";
            this.cbRenameType.Size = new System.Drawing.Size(121, 20);
            this.cbRenameType.TabIndex = 4;
            this.cbRenameType.SelectionChangeCommitted += new System.EventHandler(this.cbRenameType_SelectionChangeCommitted);
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(115, 90);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(519, 21);
            this.txtExpression.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Before :";
            // 
            // lblOriginName
            // 
            this.lblOriginName.AutoSize = true;
            this.lblOriginName.Location = new System.Drawing.Point(112, 127);
            this.lblOriginName.Name = "lblOriginName";
            this.lblOriginName.Size = new System.Drawing.Size(0, 12);
            this.lblOriginName.TabIndex = 3;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(112, 162);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(0, 12);
            this.lblNewName.TabIndex = 3;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(456, 348);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 21);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 381);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.cbRenameType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.lblOriginName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnExecute);
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
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRenameType;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOriginName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button btnPreview;
    }
}

