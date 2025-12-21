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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem item = new ListViewItem(txtID.Text.Trim());

            if (rbMale.Checked)
            {
                item.ImageIndex = 0;
            }
            else
            {
                item.ImageIndex = 1;
            }

            item.SubItems.Add(txtName.Text.Trim());

            listView1.Items.Add(item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();

        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {

            if (rbDetails.Checked)
            {
                listView1.View = View.Details;
            }

        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {

            if (rbSmallIcon.Checked)
            {
                listView1.View = View.SmallIcon;
            }

        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {

            if (rbLargeIcon.Checked)
            {
                listView1.View = View.LargeIcon;
            }

        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {

            if (rbList.Checked)
            {
                listView1.View = View.List;
            }

        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {

            if (rbTile.Checked)
            {
                listView1.View = View.Tile;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }

            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {

            for(int i = 0; i<10;i++)
            {

                ListViewItem item = new ListViewItem(i.ToString());

                if(i % 2 == 0)
                {
                    item.ImageIndex= 0;
                }
                else
                {
                    item.ImageIndex= 1;
                }

                item.SubItems.Add("Person" + i);

                listView1.Items.Add(item);

            }

        }
    }
}
