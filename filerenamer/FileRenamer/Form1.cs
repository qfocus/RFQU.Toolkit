using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Microsoft.Practices.Unity;
using FileRenamer.Business;

namespace FileRenamer.UI
{
    public partial class Form1 : Form
    {
        private IUnityContainer _container;

        IFileRenamer _renamer;

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

            btnExecute.Enabled = false;

        }

        private void InitializeData()
        {
            cbRenameType.DataSource = new List<string>() { "RemoveCharacter", "ReplaceCharacter" };

            _renamer = _container.Resolve<IFileRenamer>("RemoveCharacter");

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(fbdChooseFolder.SelectedPath);

            foreach (var item in files)
            {
                string originName = Path.GetFileName(item);

                string newName = _renamer.Rename(originName, txtExpression.Text);

                string newPath = Path.Combine(fbdChooseFolder.SelectedPath, newName);

                File.Move(item, newPath);

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreView();
        }

        private void cbRenameType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = ((ComboBox)sender).Text;

            this._renamer = _container.Resolve<IFileRenamer>(name);
        }

        private void PreView()
        {
            if (string.IsNullOrEmpty(txtExpression.Text) || string.IsNullOrEmpty(fbdChooseFolder.SelectedPath))
            {
                return;
            }

            var files = Directory.GetFiles(fbdChooseFolder.SelectedPath);

            string originName = Path.GetFileName(files[0]);

            string newName = _renamer.Rename(originName, txtExpression.Text);

            lblOriginName.Text = originName;

            lblNewName.Text = newName;

            btnExecute.Enabled = true;
        }

    }
}