using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, EventArgs e)
        {

            Form frm1 = new Form1();
            frm1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form frm1 = new Form1();
            frm1.ShowDialog();

        }

        private void btnMessageBoxForm_Click(object sender, EventArgs e)
        {

            Form frmMessageBox = new frmMessageBox();
            frmMessageBox.ShowDialog();

        }

        private void btnCheckBoxForm_Click(object sender, EventArgs e)
        {
            Form frmChkBoxGroup = new frmChkRadioGroup();
            frmChkBoxGroup.ShowDialog();
        }

        private void btnMoreAboutTextBox_Click(object sender, EventArgs e)
        {

            Form frmTextBox = new frmTextBox();
            frmTextBox.ShowDialog();

        }

        private void btnShowPicBox_Click(object sender, EventArgs e)
        {

            Form frmPictureBox = new frmPictureBox();
            frmPictureBox.ShowDialog();

        }

        private void btnFormPaint_Click(object sender, EventArgs e)
        {
            Form frmPainting = new frmPainting();
            frmPainting.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form frmMaskedTextBox = new frmMaskedTextBox();
            frmMaskedTextBox.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form frmComboBox = new frmComboBox();
            frmComboBox.Show();

        }
    }
}
