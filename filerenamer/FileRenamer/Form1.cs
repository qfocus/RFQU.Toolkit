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

        private string removeOperator = "RemoveCharacter";
        private string replaceOperator = "ReplaceCharacter";
        private IUnityContainer _container;

        IFileRenamer renamer;

        public Form1(IUnityContainer container)
        {
            this._container = container;

            InitializeComponent();

            InitializeData();
        }

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdChooseFolder.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            ShowSource();

            txtSourceFolder.Text = fbdChooseFolder.SelectedPath;

            btnExecute.Enabled = false;

        }

        private void InitializeData()
        {
            cbRenameType.DataSource = new List<string>() { "RemoveCharacter", "ReplaceCharacter" };

            renamer = _container.Resolve<IFileRenamer>("RemoveCharacter");

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }

            var files = Directory.GetFiles(txtSourceFolder.Text);

            foreach (var item in files)
            {
                string originName = Path.GetFileName(item);

                string newName = renamer.Rename(originName, txtOldCharacter.Text, txtNewCharacter.Text);

                //name doesn't change
                if (string.Equals(originName, newName))
                {
                    continue;
                }

                string newPath = Path.Combine(txtSourceFolder.Text, newName);

                File.Move(item, newPath);

            }
            MessageBox.Show("Complete!", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowSource();            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreView();
        }

        private void cbRenameType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = ((ComboBox)sender).Text;

            this.renamer = _container.Resolve<IFileRenamer>(name);

            if (name == removeOperator)
            {
                txtNewCharacter.Enabled = false;
            }
            else
            {
                txtNewCharacter.Enabled = true;
            }

        }

        private void PreView()
        {
            ClearResult();

            if (!IsValid())
            {
                return;
            }


            var files = Directory.GetFiles(txtSourceFolder.Text);

            foreach (var item in files)
            {
                string originName = Path.GetFileName(item);

                string newName = renamer.Rename(originName, txtOldCharacter.Text, txtNewCharacter.Text);

                lbResult.Items.Add(newName);
            }

            btnExecute.Enabled = true;
        }

        private void ShowSource()
        {
            lbSource.Items.Clear();
            if (txtSourceFolder.Text == null || !Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                return;
            }

            var files = Directory.GetFiles(txtSourceFolder.Text);

            foreach (var file in files)
            {
                string name = Path.GetFileName(file);
                lbSource.Items.Add(name);
            }

        }

        private void ClearSource()
        {
            lbSource.Items.Clear();
        }

        private void ClearResult()
        {
            lbResult.Items.Clear();
        }

        private bool IsValid()
        {
            if (!string.IsNullOrEmpty(txtSourceFolder.Text) &&
                Directory.Exists(txtSourceFolder.Text.Trim()) &&
                !string.IsNullOrEmpty(txtOldCharacter.Text))
            {
                return true;
            }
            MessageBox.Show("Invalid input!");
            return false;
        }

        private void TxtSourceFolder_TextChanged(object sender, EventArgs e)
        {
            ShowSource();
        }
    }
}