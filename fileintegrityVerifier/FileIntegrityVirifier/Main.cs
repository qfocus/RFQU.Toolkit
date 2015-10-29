using HashIntegrityVirifier.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashIntegrityVirifier
{
    public partial class FileIntegrityVerifier : Form
    {
        public FileIntegrityVerifier()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ClearText();

                lblFilePath.Text = openFileDialog.FileName;
            }

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(openFileDialog.FileName))
            {
                MessageBox.Show("File does not exists!");
                return;
            }

            try
            {
                using (Stream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    string md5 = GetHash(stream, "MD5");

                    stream.Seek(0, SeekOrigin.Begin);

                    string sha1 = GetHash(stream, "SHA1");

                    txtFileMd5.Text = md5;

                    txtFileSha1.Text = sha1;

                    SetImage(pbMd5, md5, txtMd5.Text);

                    SetImage(pbSha1, sha1, txtSha1.Text);

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("File is opened by another appliaction!");
            }

        }

        private void SetImage(PictureBox pictureBox, string value1, string value2)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.ClientSize = new System.Drawing.Size(25, 25);

            if (string.Equals(value1, value2))
            {
                pictureBox.Image = Resources.right;
            }
            else
            {
                pictureBox.Image = Resources.wrong;
            }
        }


        private string GetHash(Stream stream, string hashName)
        {
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create(hashName);

            byte[] computedHash = hashAlgorithm.ComputeHash(stream);

            StringBuilder builder = new StringBuilder();

            foreach (var item in computedHash)
            {
                builder.Append(string.Format("{0:X2}", item));
            }

            return builder.ToString();
        }


        private void ClearText()
        {
            var controls = this.Controls;

            foreach (var item in controls)
            {
                TextBox textbox = item as TextBox;

                if (textbox != null)
                {
                    textbox.Clear();
                }
            }

            pbMd5.Image = null;
            pbSha1.Image = null;

        }

        private void HashIntegrityVerifier_Load(object sender, EventArgs e)
        {

        }

    }
}
