using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstWinFormsProject.Forms;

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

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmLinkLabel = new frmLinkLabel();
            frmLinkLabel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form frmCheckedListBox = new frmCheckedListBox();
            frmCheckedListBox.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form frmDateTimePicker = new frmDateTimePicker();
            frmDateTimePicker.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form frmMonthCalender = new frmMonthCalender();
            frmMonthCalender.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form frmTimer = new frmTimer(); 
            frmTimer.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Form frmNotifyIcon = new frmNotifyIcon();

            frmNotifyIcon.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
