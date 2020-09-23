namespace Notification
{
    partial class Notification
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.Status = new System.Windows.Forms.GroupBox();
            this.rbDisable = new System.Windows.Forms.RadioButton();
            this.rbEnable = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.startsOnBoot = new System.Windows.Forms.CheckBox();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Controls.Add(this.rbDisable);
            this.Status.Controls.Add(this.rbEnable);
            this.Status.Location = new System.Drawing.Point(25, 65);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(156, 50);
            this.Status.TabIndex = 0;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // rbDisable
            // 
            this.rbDisable.AutoSize = true;
            this.rbDisable.Location = new System.Drawing.Point(82, 20);
            this.rbDisable.Name = "rbDisable";
            this.rbDisable.Size = new System.Drawing.Size(60, 17);
            this.rbDisable.TabIndex = 4;
            this.rbDisable.Text = "Disable";
            this.rbDisable.UseVisualStyleBackColor = true;
            // 
            // rbEnable
            // 
            this.rbEnable.AutoSize = true;
            this.rbEnable.Checked = true;
            this.rbEnable.Location = new System.Drawing.Point(18, 20);
            this.rbEnable.Name = "rbEnable";
            this.rbEnable.Size = new System.Drawing.Size(58, 17);
            this.rbEnable.TabIndex = 3;
            this.rbEnable.TabStop = true;
            this.rbEnable.Text = "Enable";
            this.rbEnable.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(287, 92);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.Ok_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 999;
            this.label1.Text = "Message";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(79, 39);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(102, 20);
            this.timePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 999;
            this.label2.Text = "Time";
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Q";
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // startsOnBoot
            // 
            this.startsOnBoot.AutoSize = true;
            this.startsOnBoot.Checked = true;
            this.startsOnBoot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startsOnBoot.Location = new System.Drawing.Point(203, 39);
            this.startsOnBoot.Name = "startsOnBoot";
            this.startsOnBoot.Size = new System.Drawing.Size(164, 17);
            this.startsOnBoot.TabIndex = 1000;
            this.startsOnBoot.Text = "Starts when Windows startup";
            this.startsOnBoot.UseVisualStyleBackColor = true;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 129);
            this.Controls.Add(this.startsOnBoot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q";
            this.Resize += new System.EventHandler(this.Notification_Resize);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.RadioButton rbDisable;
        private System.Windows.Forms.RadioButton rbEnable;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.CheckBox startsOnBoot;
    }
}

