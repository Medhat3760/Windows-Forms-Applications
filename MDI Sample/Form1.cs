using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form frm2;

        private void button1_Click(object sender, EventArgs e)
        {

            if (frm2 == null || frm2.IsDisposed)
            {

                frm2 = new Form();
                frm2.MdiParent = this;
                frm2.Show();

            }
            else
            {

                frm2.BringToFront();
                frm2.Activate();

            }


        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find Client is here.");
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Client is here.");

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Client is here.");

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Client is here.");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit is here.");

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login is here.");

        }

        Form frm3;

        private void Form2_Click(object sender, EventArgs e)
        {

            if (frm3 == null || frm3.IsDisposed)
            {

                frm3 = new Form2();
                frm3.MdiParent = this;
                frm3.Show();

            }
            else
            {
                frm3.BringToFront();
                frm3.Activate();
            }

        }
    }
}
