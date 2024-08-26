using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lauch2
{
    public partial class NewProcess : Form
    {
        public NewProcess()
        {
            InitializeComponent();
        }

        private void NewProcess_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ProcessItem item = new ProcessItem();
            item.Filename = textBoxFilename.Text;
            item.workDir = textBoxDir.Text;
            item.Arguments = textBoxArguments.Text;

            bool save = ProcessItem.save(item);

            if (save)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao salvar");
            }
        }

        private void Clear()
        {
            textBoxFilename.Clear();
            textBoxArguments.Clear();
            textBoxDir.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            var response = openFileDialog.ShowDialog();

            if (response == DialogResult.OK)
            {
                textBoxFilename.Text = openFileDialog.FileName;
            }
        }

        private void buttonDir_Click(object sender, EventArgs e)
        {
            var response = folderBrowserDialog.ShowDialog();

            if (response == DialogResult.OK) {
                textBoxDir.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
