using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdChooseFolder.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            lblFolderLocation.Text = fbdChooseFolder.SelectedPath;

            Rename();
        }


        private void Rename()
        {
            string[] files = Directory.GetFiles(fbdChooseFolder.SelectedPath);

            foreach (var item in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(item);


            }
        }
    }
}