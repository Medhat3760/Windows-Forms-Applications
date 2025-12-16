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
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {

            for (short i = 1; i <= 5; i++)
            {

                checkedListBox1.Items.Add("Item" + i);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.Items.Count >= 3)
            {

                checkedListBox1.Items.RemoveAt(2);

            }
            else
            {
                MessageBox.Show("Out Of Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
