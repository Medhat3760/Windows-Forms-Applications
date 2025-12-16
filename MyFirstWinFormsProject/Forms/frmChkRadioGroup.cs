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
    public partial class frmChkRadioGroup : Form
    {
        public frmChkRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkRecieveEmail.Checked.ToString());
        }

        private void chkRecieveEmail_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = chkRecieveEmail.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Checked.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = false;
        }
    }
}
