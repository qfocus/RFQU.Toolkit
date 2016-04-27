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
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRenameType = new System.Windows.Forms.ComboBox();
            this.txtOldCharacter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOldName = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewCharacter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(13, 13);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(99, 23);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(559, 377);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Old Character :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "After :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rename Type : ";
            // 
            // cbRenameType
            // 
            this.cbRenameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenameType.FormattingEnabled = true;
            this.cbRenameType.Location = new System.Drawing.Point(115, 52);
            this.cbRenameType.Name = "cbRenameType";
            this.cbRenameType.Size = new System.Drawing.Size(121, 21);
            this.cbRenameType.TabIndex = 4;
            this.cbRenameType.SelectionChangeCommitted += new System.EventHandler(this.cbRenameType_SelectionChangeCommitted);
            // 
            // txtOldCharacter
            // 
            this.txtOldCharacter.Location = new System.Drawing.Point(115, 98);
            this.txtOldCharacter.Name = "txtOldCharacter";
            this.txtOldCharacter.Size = new System.Drawing.Size(519, 20);
            this.txtOldCharacter.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Before :";
            // 
            // lblOldName
            // 
            this.lblOldName.AutoSize = true;
            this.lblOldName.Location = new System.Drawing.Point(112, 172);
            this.lblOldName.Name = "lblOldName";
            this.lblOldName.Size = new System.Drawing.Size(50, 13);
            this.lblOldName.TabIndex = 3;
            this.lblOldName.Text = "old name";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(112, 210);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(56, 13);
            this.lblNewName.TabIndex = 3;
            this.lblNewName.Text = "new name";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(456, 377);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(119, 13);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(515, 20);
            this.txtSourceFolder.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Character:";
            // 
            // txtNewCharacter
            // 
            this.txtNewCharacter.Location = new System.Drawing.Point(115, 134);
            this.txtNewCharacter.Name = "txtNewCharacter";
            this.txtNewCharacter.Size = new System.Drawing.Size(519, 20);
            this.txtNewCharacter.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 413);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.txtNewCharacter);
            this.Controls.Add(this.txtOldCharacter);
            this.Controls.Add(this.cbRenameType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.lblOldName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnExecute);
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
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRenameType;
        private System.Windows.Forms.TextBox txtOldCharacter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOldName;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewCharacter;
    }
}

