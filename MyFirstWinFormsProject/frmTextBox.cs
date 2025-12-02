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
    public partial class frmTextBox : Form
    {
        public frmTextBox()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                textBox1.PasswordChar= '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
        }
    }
}
