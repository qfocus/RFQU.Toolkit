using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Practices.Unity;
using FileRenamer.BusinessLogic;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        private IUnityContainer _container;

        public Form1(IUnityContainer container)
        {
            this._container = container;

            InitializeComponent();

            InitializeData();
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

        private void InitializeData()
        {
            cbRenameType.DataSource = new List<string>() { "RemoveCharacter", "ReplaceCharacter" };

            IFileReNamer renamer = _container.Resolve<IFileReNamer>("replace");

            renamer.Rename("x");
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