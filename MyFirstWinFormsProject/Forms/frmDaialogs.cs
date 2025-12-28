using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject.Forms
{
    public partial class frmDaialogs : Form
    {
        public frmDaialogs()
        {
            InitializeComponent();
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {

            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.BackColor = colorDialog1.Color;

            }

        }

        private void btnChangeForeColor_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.ForeColor = colorDialog1.Color;

            }

        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowEffects = true;
            //fontDialog1.ShowHelp = true;

            fontDialog1.Font = textBox1.Font;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox1.Font= fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;

            }

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

            textBox1.Font = fontDialog1.Font;
            textBox1.ForeColor = fontDialog1.Color;

        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Title = "Save File As";
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 3;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Open File";
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;

            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }

        }

        private void btnOpenFileDialogMulti_Click(object sender, EventArgs e)
        {

            openFileDialog1.Multiselect = true;
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                foreach (string fileName in openFileDialog1.FileNames)
                {
                    MessageBox.Show(fileName);
                }

            }

        }

        private void btnFolderBrowserDialog_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show(folderBrowserDialog1.SelectedPath);

            }

        }
    }
}
