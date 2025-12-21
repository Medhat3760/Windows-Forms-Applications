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
    public partial class frmImageList : Form
    {
        public frmImageList()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        void CheckTreeViewNode(TreeNode node, bool isChecked)
        {

            foreach(TreeNode itemNode in node.Nodes)
            {

                itemNode.Checked = isChecked;

                if(itemNode.Nodes.Count > 0)
                {
                    CheckTreeViewNode(itemNode, isChecked);
                }

            }

        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }
    }
}
