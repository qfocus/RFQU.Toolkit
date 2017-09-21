using JsonConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.openFileDialog1.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                this.execute.Enabled = false;
                return;
            }

            string fileName = this.openFileDialog1.FileName;

            if (!File.Exists(fileName))
            {
                MessageBox.Show("File does not exists.");
                return;
            }
            this.filePath.Text = this.openFileDialog1.FileName;
            this.execute.Enabled = true;
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.openFileDialog1.FileName))
            {
                MessageBox.Show("File does not exists.");
                return;
            }

            Converter converter = new Converter();

            converter.Convert(this.openFileDialog1.FileName,(Direction)this.comboBox1.SelectedItem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Direction> list = new List<Direction>();
            list.Add(Direction.Row);
            list.Add(Direction.Column);

            this.comboBox1.DataSource = list;
            
        }
    }
}
