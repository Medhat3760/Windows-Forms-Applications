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
    public partial class frmNotifyIcon : Form
    {
        public frmNotifyIcon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "This is a title";
            notifyIcon1.BalloonTipText = "This is a message";
            notifyIcon1.ShowBalloonTip(1000);

        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Baloon Tip Clicked");
        }

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter++;

            if(counter == 60)
            {

                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.ShowBalloonTip(1000, "اذكر الله", "سبحان الله وبحمده..سبحان الله العظيم", ToolTipIcon.Info);

                counter = 0;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

    }
}
