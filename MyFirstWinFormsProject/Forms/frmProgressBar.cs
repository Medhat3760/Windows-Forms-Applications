using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstWinFormsProject.Forms
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            /*while (progressBar1.Value < progressBar1.Maximum)
            //{

            //    Thread.Sleep(500);

            //    progressBar1.Value += 10;

            //    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString("0") + "%";

            //    progressBar1.Refresh();
            //    label1.Refresh();

            //}

            //button1.Enabled = false;
            */

            button1.Enabled = false;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(progressBar1.Value < progressBar1.Maximum)
            {

                progressBar1.Value += 10;

                label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100).ToString("0") + "%";

            }
            else
            {
                timer1.Stop();
                button1.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Stop();

            progressBar1.Value= 0;

            label1.Text = "0%";

            button1.Enabled= true;

        }
    }
}
